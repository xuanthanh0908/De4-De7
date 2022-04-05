using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            dgvCD.DataSource = Load_form().Tables["CongDan"];
            dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       public DataSet Load_form()
       {
            DataSet data = new DataSet();

            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "Select * from CongDan";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(data, "CongDan");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return data;
       }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "UPDATE CONGDAN SET TENCD = '"+txtTenCD.Text+"' WHERE MACD = '"+txtMaCD.Text+"' ";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query,connection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            dgvCD.DataSource = Load_form().Tables["CongDan"];
            dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
