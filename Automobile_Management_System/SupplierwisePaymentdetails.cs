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
    public partial class SupplierwisePaymentdetails : Form
    {
        public SupplierwisePaymentdetails()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        
        private void search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM VW_SUPPLIERWISEPAYMENTDETAILS WHERE SUPPLIERNAME='" + SUPPLIERNAME.Text + "'", CON);
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

        private void SUPPLIERNAME_TextChanged(object sender, EventArgs e)
        {
            if (SUPPLIERNAME.Text != "")
            {

                SqlDataAdapter AD = new SqlDataAdapter("SELECT SUPPLIERNAME FROM SUPPLIER WHERE SUPPLIERNAME LIKE'" + SUPPLIERNAME.Text + "%'", CON);

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

        private void SUPPLIERNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
            }


        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SUPPLIERNAME.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
