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
    public partial class Servicing : Form
    {
        public Servicing()
        {
            InitializeComponent();
        }
        private void calculation()
        {
            double r = 0;
            double q = 0;
            double tamount = 0;
            double s = 0;
            
            if (RATE.Text != "")
            {
                r = Convert.ToDouble(RATE.Text);
            }
            if (QUANTITY.Text != "")
            {
                q = Convert.ToDouble(QUANTITY.Text);
            }
            if (SERVICECHARGE.Text != "")
            {
                s = Convert.ToDouble(SERVICECHARGE.Text);
            }

            tamount = r * q+s;
            TOTALAMOUNT.Text = tamount.ToString();

        }
        
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        
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

        private void Servicing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUTOMOBILEDataSet1.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.aUTOMOBILEDataSet1.product);

        }

        private void search_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM CUSTOMER WHERE CUSTOMERNAME='" + CUSTOMERNAME.Text + "'", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {


                CUSTOMERID.Text = DS.Tables[0].Rows[0]["CUSTOMERID"].ToString();

            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                /*if (SERVICINGID.Text == "")
                {
                    cmd.Parameters.AddWithValue("@SERVICINGID", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SERVICINGID", SERVICINGID.Text);
                }*/

                cmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID.Text);
                cmd.Parameters.AddWithValue("@VEHICLENAME_MODEL", VNAMEANDMODEL.Text);
                cmd.Parameters.AddWithValue("@RATE", RATE.Text);
                cmd.Parameters.AddWithValue("@PRODUCTID", PRODUCTID.Text);
                cmd.Parameters.AddWithValue("@QUANTITY", QUANTITY.Text);
                cmd.Parameters.AddWithValue("@SERVICE_CHARGE", SERVICECHARGE.Text);
                cmd.Parameters.AddWithValue("@SERVICING_DATE", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@TOTALAMOUNT", TOTALAMOUNT.Text);
              
                
                
                SqlParameter error = cmd.Parameters.Add("@ERRORMSG",
                SqlDbType.VarChar, 1000);
                error.Direction = ParameterDirection.Output;
                SqlParameter returnvalue =
                cmd.Parameters.Add("@ret", SqlDbType.Int);
                returnvalue.Direction =
                ParameterDirection.ReturnValue;
                cmd.Connection = CON;
                cmd.CommandText = "SP_SERVICING";
                cmd.CommandType = CommandType.StoredProcedure;
                CON.Open();
                cmd.ExecuteNonQuery();
                int r = 0;
                //r = (int)returnvalue.Value;
                r = Convert.ToInt32(returnvalue.Value);
                if (r > 0)
                {
                   

                        MessageBox.Show("DATA IS SAVED");
                        CUSTOMERNAME.Clear();
                        CUSTOMERID.Clear();
                        TOTALAMOUNT.Clear();
                        VNAMEANDMODEL.Clear();
                        RATE.Clear();
                        QUANTITY.Clear();
                        SERVICECHARGE.Clear();
                        ProductName.Clear();
                        PRODUCTID.Clear();
                    
                        
                   
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                LBPRODUCTNAME.Focus();
            }
  
        }

        private void listBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ProductName.Text = LBPRODUCTNAME.SelectedItem.ToString();
                LBPRODUCTNAME.Visible = false;
                SqlDataAdapter ad = new SqlDataAdapter("select productid,price from product where  productname='" + ProductName.Text + "'", CON);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    PRODUCTID.Text = ds.Tables[0].Rows[0]["productid"].ToString();
                    RATE.Text = ds.Tables[0].Rows[0]["price"].ToString();
                
                }

            }

        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {
            if (ProductName.Text != "")
            {
                SqlDataAdapter adptr = new SqlDataAdapter("select productname from product where productname like '" + ProductName.Text + "%'", CON);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                LBPRODUCTNAME.Items.Clear();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        LBPRODUCTNAME.Visible = true;
                        LBPRODUCTNAME.Items.Add(dr[0]);
                    }
                }
                else
                {
                    LBPRODUCTNAME.Items.Clear();
                    LBPRODUCTNAME.Visible = false;
                }
            }
            else
            {
                LBPRODUCTNAME.Items.Clear();
                LBPRODUCTNAME.Visible = false;
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

        private void SERVICECHARGE_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void TOTALAMOUNT_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

       
    }
}
