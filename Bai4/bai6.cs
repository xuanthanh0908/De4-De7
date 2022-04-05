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
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
            dgvCD.DataSource = load_form().Tables["CongDan"];
            dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet load_form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "Select * from CongDan";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "Congdan");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : "+ ex.Message);
            }
            return dataSet;
        }
        public DataSet check()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "Select * from CongDan where MACD = '"+txtMACD.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "Congdan01");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return dataSet;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "DELETE CONGDAN WHERE MACD = '"+txtMACD.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                if (check().Tables["Congdan01"].Rows.Count  > 0)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có Công dân phù hợp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            dgvCD.DataSource = load_form().Tables["CongDan"];
            dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
