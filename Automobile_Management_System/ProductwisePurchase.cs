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
    public partial class ProductwisePurchase : Form
    {
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());

        public ProductwisePurchase()
        {
            InitializeComponent();
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM VW_PURCHASE WHERE PRODUCTNAME='" + PRODUCTNAME.Text + "'", CON);
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

        private void PRODUCTNAME_TextChanged(object sender, EventArgs e)
        {
            if (PRODUCTNAME.Text != "")
            {

                SqlDataAdapter AD = new SqlDataAdapter("SELECT PRODUCTNAME FROM VW_PURCHASE WHERE PRODUCTNAME LIKE'" + PRODUCTNAME.Text + "%'", CON);

                DataSet DS = new DataSet();
                AD.Fill(DS);
                listBox1.Items.Clear();
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow DR in DS.Tables[0].Rows)
                    {
                        listBox1.Visible = true;
                        listBox1.Items.Add(DR[0]);
                    }
                }
                else
                {

                    listBox1.Items.Clear();
                    listBox1.Visible = false;
                }
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Visible = false;

            }
        
        }

        private void PRODUCTNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
            }

        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PRODUCTNAME.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;


        }

        }
}
