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
    public partial class Supplierpayment : Form
    {
        public Supplierpayment()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
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
            REMAININGAMOUNT.Text = r.ToString();


        }
     
        private void save_Click(object sender, EventArgs e)
        {
            try
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

                cmd.Parameters.AddWithValue("@TOTALAMOUNT", TOTALAMOUNT.Text);
                cmd.Parameters.AddWithValue("@PAIDAMOUNT", PAIDAMOUNT.Text);
                cmd.Parameters.AddWithValue("@PAIDDATE", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@PAYMENTTYPE", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@CHEQUENO", CHEQUENO.Text);

                SqlParameter error = cmd.Parameters.Add("@ERRORMSG",
                SqlDbType.VarChar, 1000);
                error.Direction = ParameterDirection.Output;
                SqlParameter returnvalue =
                cmd.Parameters.Add("@ret", SqlDbType.Int);
                returnvalue.Direction =
                ParameterDirection.ReturnValue;
                cmd.Connection = CON;
                cmd.CommandText = "SP_SUPPLIERPAYMENT";
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
                    MessageBox.Show("DATA IS SAVED");
                    SUPPLIERID.Clear();
                    SUPPLIERNAME.Clear();
                    TOTALAMOUNT.Clear();
                    PAIDAMOUNT.Clear();
                    REMAININGAMOUNT.Clear();
                    //PAYMENTTYPE.Clear();
                    CHEQUENO.Clear();
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

        private void search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM SUPPLIER WHERE SUPPLIERNAME='" + SUPPLIERNAME.Text + "'", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);

            if (DS.Tables[0].Rows.Count > 0)
            {


                SUPPLIERID.Text = DS.Tables[0].Rows[0]["SUPPLIERID"].ToString();



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

        private void TOTALAMOUNT_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void PAIDAMOUNT_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void REMAININGAMOUNT_TextChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CASH")
            {
                lBCHEQUENO.Visible = false;
                CHEQUENO.Visible = false;
            }
            else
            {
                lBCHEQUENO.Visible = true;
                CHEQUENO.Visible = true;
            }
        }
    }
}
