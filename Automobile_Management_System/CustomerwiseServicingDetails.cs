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
    public partial class CustomerwiseServicingDetails : Form
    {
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());

        public CustomerwiseServicingDetails()
        {
            InitializeComponent();
        }

        
        private void search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT *FROM VW_CUSTOMERWISESERVICING where customername like '" + CUSTOMERNAME.Text + "%'", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);
            CON.Open();
            if (DS.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }

        }

        private void CUSTOMERNAME_TextChanged(object sender, EventArgs e)
        {
            if (CUSTOMERNAME.Text != "")
            {

                SqlDataAdapter AD = new SqlDataAdapter("SELECT CUSTOMERNAME FROM VW_CUSTOMERWISESERVICING WHERE CUSTOMERNAME LIKE'" + CUSTOMERNAME.Text + "%'", CON);

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

        private void CUSTOMERNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
            }

        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CUSTOMERNAME.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;

        }
    }
}
