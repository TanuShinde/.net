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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        private Boolean valid()
        {
            if (COMPANYNAME.Text == "")
            {
                MessageBox.Show("ENTER THE COMPANY NAME");
                return false;
            }
            if (CONTACTNO.Text == "")
            {
                MessageBox.Show("ENTER THE CONTACT NUMBER");
                return false;
            }
            if (SUPPLIERNAME.Text == "")
            {
                MessageBox.Show("ENTER THE SUPPLIER NAME");
                return false;
            }
            if (ADDRESS.Text == "")
            {
                MessageBox.Show("ENTER THE ADDRESS");
                return false;
            }
            if (GSTNO.Text == "")
            {
                MessageBox.Show("ENTER THE GST NO");
                return false;
            }
            return true;
        }
        
        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (valid())
                {
                    SqlCommand cmd = new SqlCommand();
                    if (SUPPLIERID.Text == "")
                    {
                        cmd.Parameters.AddWithValue("@SUPPLIERID", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SUPPLIERID", SUPPLIERID.Text);
                    }
                    cmd.Parameters.AddWithValue("@COMNPANYNAME", COMPANYNAME.Text);
                    cmd.Parameters.AddWithValue("@SUPPLIERNAME", SUPPLIERNAME.Text);
                    cmd.Parameters.AddWithValue("@CONTACTNUMBER", CONTACTNO.Text);
                    cmd.Parameters.AddWithValue("@ADDRESS", ADDRESS.Text);
                    cmd.Parameters.AddWithValue("@GSTNO", GSTNO.Text);
                    SqlParameter error = cmd.Parameters.Add("@ERRORMSG",
                    SqlDbType.VarChar, 1000);
                    error.Direction = ParameterDirection.Output;
                    SqlParameter returnvalue =
                    cmd.Parameters.Add("@ret", SqlDbType.Int);
                    returnvalue.Direction =
                    ParameterDirection.ReturnValue;
                    cmd.Connection = CON;
                    cmd.CommandText = "SP_SUPPLIER";
                    cmd.CommandType = CommandType.StoredProcedure;
                    CON.Open();
                    cmd.ExecuteNonQuery();
                    int r = 0;
                    //r = (int)returnvalue.Value;
                    r = Convert.ToInt32(returnvalue.Value);
                    if (r > 0)
                    {
                        MessageBox.Show("DATA IS SAVED");
                        SUPPLIERID.Clear();
                        COMPANYNAME.Clear();
                        SUPPLIERNAME.Clear();
                        CONTACTNO.Clear();
                        ADDRESS.Clear();
                        GSTNO.Clear();

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
            SqlDataAdapter AD = new SqlDataAdapter("SELECT*FROM SUPPLIER WHERE SUPPLIERNAME='" + SUPPLIERNAME.Text + "'", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {
                SUPPLIERID.Text = DS.Tables[0].Rows[0]["SUPPLIERID"].ToString();
                SUPPLIERNAME.Text = DS.Tables[0].Rows[0]["SUPPLIERNAME"].ToString();
                COMPANYNAME.Text = DS.Tables[0].Rows[0]["COMNPANYNAME"].ToString();
                CONTACTNO.Text = DS.Tables[0].Rows[0]["CONTACTNUMBER"].ToString();
                ADDRESS.Text = DS.Tables[0].Rows[0]["ADDRESS"].ToString();
                GSTNO.Text = DS.Tables[0].Rows[0]["GSTNO"].ToString();
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

          }
}
