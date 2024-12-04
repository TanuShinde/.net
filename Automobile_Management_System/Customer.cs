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
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        public Customer()
        {
            InitializeComponent();
        }
        private Boolean valid()
        {
            if (CUSTOMERNAME.Text == "")
            {
                MessageBox.Show("ENTER CUSTOMERNAME ");
                return false;
            }


            if (MOBILENO.Text == "")
            {
                MessageBox.Show("ENTER MOBILE NUMBER");
                return false;
            }
            return true;
        }
       

        private void INSERT_Click(object sender, EventArgs e)
        {
            try
            {
                if (valid())
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.AddWithValue("@CUSTOMERNAME", CUSTOMERNAME.Text);
                    cmd.Parameters.AddWithValue("@MOBILE", MOBILENO.Text);
                    SqlParameter error = cmd.Parameters.Add("@ERRORMSG",
                    SqlDbType.VarChar, 1000);
                    error.Direction = ParameterDirection.Output;
                    SqlParameter returnvalue =
                    cmd.Parameters.Add("@ret", SqlDbType.Int);
                    returnvalue.Direction =
                    ParameterDirection.ReturnValue;
                    cmd.Connection = con;
                    cmd.CommandText = "SP_CUSTOMER";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int r = 0;
                    //r = (int)returnvalue.Value;
                    r = Convert.ToInt32(returnvalue.Value);
                    if (r > 0)
                    {
                        MessageBox.Show(" DATA IS SAVED");
                        CUSTOMERID.Clear();
                        CUSTOMERNAME.Clear();
                        MOBILENO.Clear();
                    }
                    else
                    {
                        string str;
                        str = (string)error.Value;
                        MessageBox.Show(str);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT*FROM CUSTOMER WHERE CUSTOMERNAME='" + CUSTOMERNAME.Text + "'", con);
            DataSet DS = new DataSet();
            AD.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {
                CUSTOMERID.Text = DS.Tables[0].Rows[0]["CUSTOMERID"].ToString();
                CUSTOMERNAME.Text = DS.Tables[0].Rows[0]["CUSTOMERNAME"].ToString();

                MOBILENO.Text = DS.Tables[0].Rows[0]["MOBILENO"].ToString();
                
            }
            else
            {
                MessageBox.Show("RECORD NOT FOUND");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CUSTOMERNAME_TextChanged(object sender, EventArgs e)
        {
            if (CUSTOMERNAME.Text != "")
            {

                SqlDataAdapter AD = new SqlDataAdapter("SELECT CUSTOMERNAME FROM CUSTOMER WHERE CUSTOMERNAME LIKE'" + CUSTOMERNAME.Text + "%'", con);

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
            if (e.KeyChar == 13)
            {
                CUSTOMERNAME.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
