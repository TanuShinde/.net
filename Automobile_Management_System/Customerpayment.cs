using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Automobile_Management_System
{
    public partial class Customerpayment : Form
    {
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        
        public Customerpayment()
        {
            InitializeComponent();
        }
        private void calculation()
        {
            double tamt = 0;
            double paidamt = 0;
            double r = 0;
            if (TOTALAMOUNT.Text != "")
            {
                tamt = Convert.ToDouble(TOTALAMOUNT.Text);
            }
            if (PAIDAMOUNT.Text != "")
            {
                paidamt = Convert.ToDouble(PAIDAMOUNT.Text);
            }
            r = tamt - paidamt;
            REMAININGPAYMENT.Text = r.ToString();


        }
        private Boolean valid()
        {
            if (CUSTOMERNAME.Text == "")
            {
                MessageBox.Show("ENTER CUSTOMERNAME ");
                return false;
            }


            if (TOTALAMOUNT.Text == "")
            {
                MessageBox.Show("ENTER TOTALAMOUNT");
                return false;
            }
            if (PAIDAMOUNT.Text == "")
            {
                MessageBox.Show("ENTER PAIDAMOUNT");
                return false;
            }
            if (paymenttype.Text == "")
            {
                MessageBox.Show("SELECT PAYMENTTYPE");
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
                    if (CUSTOMERID.Text == "")
                    {
                        cmd.Parameters.AddWithValue("@CUSTOMERID", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID.Text);
                    }

                    cmd.Parameters.AddWithValue("@TOTALAMOUNT", TOTALAMOUNT.Text);
                    cmd.Parameters.AddWithValue("@PAIDAMOUNT", PAIDAMOUNT.Text);
                    cmd.Parameters.AddWithValue("@PAYMENTTYPE", paymenttype.SelectedItem);
                    cmd.Parameters.AddWithValue("@TRANSACTIONNO", TRANSACTIONNO.Text);

                    cmd.Parameters.AddWithValue("@PAYMENTDATE", dateTimePicker1.Value);
                    SqlParameter error = cmd.Parameters.Add("@ERRORMSG",
                    SqlDbType.VarChar, 1000);
                    error.Direction = ParameterDirection.Output;
                    SqlParameter returnvalue =
                    cmd.Parameters.Add("@ret", SqlDbType.Int);
                    returnvalue.Direction =
                    ParameterDirection.ReturnValue;
                    cmd.Connection = CON;
                    cmd.CommandText = "SP_CUSTOMERPAYMENT";
                    cmd.CommandType = CommandType.StoredProcedure;
                    CON.Open();
                    cmd.ExecuteNonQuery();
                    int r = 0;
                    //r = (int)returnvalue.Value;
                    r = Convert.ToInt32(returnvalue.Value);
                    if (r > 0)
                    {
                        double t = Convert.ToDouble(TOTALAMOUNT.Text);
                        double p = Convert.ToDouble(PAIDAMOUNT.Text);
                        if (t == p)
                        {

                            MessageBox.Show("code is saved");
                            CUSTOMERNAME.Clear();
                            CUSTOMERID.Clear();
                            TOTALAMOUNT.Clear();
                            PAIDAMOUNT.Clear();
                            REMAININGPAYMENT.Clear();
                            TRANSACTIONNO.Clear();



                        }
                        else
                        {
                            MessageBox.Show("PAYMENT IS INCOMPLETE");
                        }
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

        
        private void CUSTOMERNAME_TextChanged(object sender, EventArgs e)
        {
            if (CUSTOMERNAME.Text != "")
            {

                SqlDataAdapter AD = new SqlDataAdapter("SELECT CUSTOMERNAME FROM CUSTOMER WHERE CUSTOMERNAME LIKE'" + CUSTOMERNAME.Text + "%'", CON);

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

        private void search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUSTOMERNAME='" + CUSTOMERNAME.Text + "'", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {


                CUSTOMERID.Text = DS.Tables[0].Rows[0]["CUSTOMERID"].ToString();
                
            }
        }

        private void TOTALAMOUNT_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void PAIDAMOUNT_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void REMAININGPAYMENT_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void paymenttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymenttype.Text == "CASH")
            {
                lbtranno.Visible = false;
                TRANSACTIONNO.Visible = false;
            }
            else
            {
                lbtranno.Visible = true;
                TRANSACTIONNO.Visible = true;
            }
        }

       
        
    }
}
