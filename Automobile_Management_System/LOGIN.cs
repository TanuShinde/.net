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
    public partial class LOGIN : Form
    {
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
       
        public LOGIN()
        {
            InitializeComponent();
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean valid()
        {
            if (user.Text == "")
            {
                MessageBox.Show("Enter the User Name");
                return false;
            }
            if (password.Text == "")
            {
                MessageBox.Show("Enter the Password");
                return false;
            }
            return true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                SqlDataAdapter ad = new SqlDataAdapter("select USERID,USERNAME,PASSWORD FROM NEWUSER  WHERE USERNAME='" + user.Text + "'", CON);

                DataSet ds = new DataSet();
                ad.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (password.Text == ds.Tables[0].Rows[0]["PASSWORD"].ToString())
                    {
                        MainMenu fm = new MainMenu();
                        fm.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Name");
                }
            }
        }

    }
}
