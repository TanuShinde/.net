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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        private void calculation()
        {
            double r = 0;
            double q = 0;
            double tamount = 0;

            if (RATE.Text != "")
            {
                r = Convert.ToDouble(RATE.Text);
            }
            if (QUANTITY.Text != "")
            {
                q = Convert.ToDouble(QUANTITY.Text);
            }

            tamount = r * q;
            TOTALAMOUNT.Text = tamount.ToString();

        }
        private void cal()
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
            REMAININGMOUNT.Text = r.ToString();


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
                MOBILENO.Text = DS.Tables[0].Rows[0]["CONTACTNUMBER"].ToString();
                ADDRESS.Text = DS.Tables[0].Rows[0]["ADDRESS"].ToString();
                GSTNO.Text = DS.Tables[0].Rows[0]["GSTNO"].ToString();
            }
        }

        private void PRODUCTNAME_TextChanged(object sender, EventArgs e)
        {
            if (PRODUCTNAME.Text != "")
            {
                SqlDataAdapter adptr = new SqlDataAdapter("select productname from product where productname like '" + PRODUCTNAME.Text + "%'", CON);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                lbproductname.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lbproductname.Visible = true;
                        lbproductname.Items.Add(dr[0]);
                    }
                }
                else
                {
                    lbproductname.Items.Clear();
                    lbproductname.Visible = false;
                }
            }
            else
            {
                lbproductname.Items.Clear();
                lbproductname.Visible = false;
            }

        }

        private void PRODUCTNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbproductname.Focus();
            }
  

        }

        private void lbproductname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PRODUCTNAME.Text = lbproductname.SelectedItem.ToString();
                lbproductname.Visible = false;
                SqlDataAdapter ad = new SqlDataAdapter("select productid from product where  productname='" + PRODUCTNAME.Text + "'", CON);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    PRODUCTID.Text = ds.Tables[0].Rows[0]["productid"].ToString();
                }



            }


        }

        private void RATE_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void QUANTITY_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void TOTALAMOUNT_TextChanged(object sender, EventArgs e)
        {
            calculation();
            cal();
        }

        private void PAIDAMOUNT_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void REMAININGAMOUNT_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@SUPPLIERID", SUPPLIERID.Text);
                cmd.Parameters.AddWithValue("@PRODUCTID", PRODUCTID.Text);

                cmd.Parameters.AddWithValue("@RATE", RATE.Text);
                cmd.Parameters.AddWithValue("@QUANTITY", QUANTITY.Text);
                cmd.Parameters.AddWithValue("@TOTALAMOUNT", TOTALAMOUNT.Text);
                cmd.Parameters.AddWithValue("@PAIDAMOUNT", PAIDAMOUNT.Text);
                cmd.Parameters.AddWithValue("@PAYMENTTYPE", comboBox2.Text);
                cmd.Parameters.AddWithValue("@PURCHASEDATE", dateTimePicker1.Value);
                SqlParameter error = cmd.Parameters.Add("@ERRORMSG", SqlDbType.VarChar, 1000);
                error.Direction = ParameterDirection.Output;
                SqlParameter returnvalue = cmd.Parameters.Add("@ret", SqlDbType.Int);
                returnvalue.Direction = ParameterDirection.ReturnValue;
                cmd.Connection = CON;
                cmd.CommandText = "SP_PURCHASE";
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
                        //CLEAR BOX QUEARY
                        SUPPLIERNAME.Clear();
                        SUPPLIERID.Clear();
                        MOBILENO.Clear();
                        COMPANYNAME.Clear();
                        GSTNO.Clear();
                        ADDRESS.Clear();
                        RATE.Clear();
                        QUANTITY.Clear();
                        TOTALAMOUNT.Clear();
                        PAIDAMOUNT.Clear();
                        REMAININGMOUNT.Clear();
                        PRODUCTNAME.Clear();
                        PRODUCTID.Clear();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CON.Close();
            }
        
        }

       
    }
}
