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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            dgvCD.DataSource = Load_form().Tables["Congdan"];
            dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "Select * from CongDan ";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.Fill(dataSet, "Congdan");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : "+ ex.Message);
            }
            return dataSet;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "UPDATE CONGDAN SET CMND = '"+txtCMND.Text+"' WHERE MACD = '"+txtMACD.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            dgvCD.DataSource = Load_form().Tables["Congdan"];
            dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
