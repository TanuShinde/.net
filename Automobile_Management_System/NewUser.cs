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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        private Boolean valid()
        {

            if (fullname.Text == "")
            {
                MessageBox.Show("ENTER FULLNAME");
                return false;
            }
            if (mobileno.Text == "")
            {
                MessageBox.Show("ENTER MOBILE NUMBER ");
                return false;
            }
            if (emailid.Text == "")
            {
                MessageBox.Show("ENTER EMAILID");
                return false;
            }
            if (username.Text == "")
            {
                MessageBox.Show("ENTER USERID");
                return false;
            }
            if (PASSWORD.Text == "")
            {
                MessageBox.Show("ENTER PASSWORD");
                return false;
            }
            if (confirmpassword.Text == "")
            {
                MessageBox.Show("ENTER CONFIRM PASSWORD");
                return false;
            }
           
           
           
            return true;
        }
           

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (valid())
                {
                    SqlCommand cmd = new SqlCommand();
                    if (USERID.Text == " ")
                    {
                        cmd.Parameters.AddWithValue("@USERID", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@USERID", USERID.Text);
                    }
                    cmd.Parameters.AddWithValue("@USERNAME", username.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD.Text);
                    cmd.Parameters.AddWithValue("@CONFIRMPASSWORD", confirmpassword.Text);
                    cmd.Parameters.AddWithValue("@FULLNAME", fullname.Text);
                    cmd.Parameters.AddWithValue("@MOBILENO", mobileno.Text);
                    cmd.Parameters.AddWithValue("@EMAILID", emailid.Text);
                    SqlParameter error = cmd.Parameters.Add("@ERRORMSG",
                    SqlDbType.VarChar, 1000);
                    error.Direction = ParameterDirection.Output;
                    SqlParameter returnvalue =
                    cmd.Parameters.Add("@ret", SqlDbType.Int);
                    returnvalue.Direction =
                    ParameterDirection.ReturnValue;
                    cmd.Connection = CON;
                    cmd.CommandText = "SP_NEWUSER";
                    cmd.CommandType = CommandType.StoredProcedure;
                    CON.Open();
                    cmd.ExecuteNonQuery();
                    int r = 0;
                    //r = (int)returnvalue.Value;
                    r = Convert.ToInt32(returnvalue.Value);
                    if (r > 0)
                    {
                        MessageBox.Show("DATA IS SAVED");
                        emailid.Clear();
                        fullname.Clear();
                        mobileno.Clear();
                        USERID.Clear();
                        username.Clear();
                        PASSWORD.Clear();
                        confirmpassword.Clear();

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

       
        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
