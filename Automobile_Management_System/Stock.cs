using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Automobile_Management_System
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUTOMOBILEDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.aUTOMOBILEDataSet.product);

        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM PRODUCT WHERE PRODUCTID='" + comboBox1.SelectedValue + "'", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("RECORD NOT FOUND");

            }
        }
    }
}
