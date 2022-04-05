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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            dgvCD.DataSource = Load_Form().Tables["CongDan"];
            dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_Form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "Select * from CongDan";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "CongDan");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return dataSet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            string query = "Select * from CongDan where CMND = '"+txtCMND.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "CongDan");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            if(dataSet.Tables["Congdan"].Rows.Count > 0)
            {
                
                dgvCD.DataSource = dataSet.Tables["CongDan"];
                dgvCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
