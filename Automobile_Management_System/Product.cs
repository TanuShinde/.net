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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());

        private Boolean valid()
        {
            if (PRODUCTNAME.Text == "")
            {
                MessageBox.Show("ENTER PRODUCTNAME");
                return false;
            }
            if (COMPANYNAME.Text == "")
            {
                MessageBox.Show("ENTER COMPANYNAME");
                return false;
            }
            if (PRICE.Text == "")
            {
                MessageBox.Show("ENTER PRICE");
                return false;
            }
            if (QUANTITY.Text == "")
            {
                MessageBox.Show("ENTER QUANTITY");
                return false;
            }


            return true;
        }
           

        private void PRODUCTNAME_TextChanged(object sender, EventArgs e)
        {
            if (PRODUCTNAME.Text != " ")
            {

                SqlDataAdapter AD = new SqlDataAdapter("SELECT PRODUCTNAME FROM PRODUCT WHERE PRODUCTNAME LIKE'" + PRODUCTNAME.Text + "%'", CON);

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

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (valid())
                {
                    SqlCommand cmd = new SqlCommand();
                    if (PRODUCTID.Text == "")
                    {

                        cmd.Parameters.AddWithValue("@productid", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@productid", PRODUCTID.Text);
                    }

                    cmd.Parameters.AddWithValue("@PRODUCTNAME", PRODUCTNAME.Text);
                    cmd.Parameters.AddWithValue("@COMPANY", COMPANYNAME.Text);
                    cmd.Parameters.AddWithValue("@PRICE", PRICE.Text);
                    cmd.Parameters.AddWithValue("@QUANTITY", QUANTITY.Text);

                    SqlParameter error = cmd.Parameters.Add("@ERRORMSG", SqlDbType.VarChar, 1000);
                    error.Direction = ParameterDirection.Output;
                    SqlParameter returnvalue =
                    cmd.Parameters.Add("@ret", SqlDbType.Int);
                    returnvalue.Direction =
                    ParameterDirection.ReturnValue;
                    cmd.Connection = CON;
                    cmd.CommandText = "SP_PRODUCTSTOCK";
                    cmd.CommandType = CommandType.StoredProcedure;
                    CON.Open();
                    cmd.ExecuteNonQuery();
                    int r = 0;
                    //r = (int)returnvalue.Value;
                    r = Convert.ToInt32(returnvalue.Value);
                    if (r > 0)
                    {
                        MessageBox.Show("DATA IS SAVED");
                        PRODUCTID.Clear();
                        PRODUCTNAME.Clear();
                        PRICE.Clear();
                        COMPANYNAME.Clear();
                        QUANTITY.Clear();
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
                CON.Close();
            }
        
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT*FROM PRODUCT WHERE PRODUCTNAME='" + PRODUCTNAME.Text + "'", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);
            CON.Open();
            if (DS.Tables[0].Rows.Count > 0)
            {
                PRODUCTID.Text = DS.Tables[0].Rows[0]["PRODUCTID"].ToString();

                COMPANYNAME.Text = DS.Tables[0].Rows[0]["COMPANY"].ToString();
                PRICE.Text = DS.Tables[0].Rows[0]["PRICE"].ToString();
                QUANTITY.Text = DS.Tables[0].Rows[0]["QUANTITY"].ToString();
            
            }
            else
            {
                MessageBox.Show("RECORD NOT FOUND");

            }
            CON.Close();

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
    }
}
