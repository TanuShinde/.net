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
    public partial class AllSupplierPaymentDetails : Form
    {
        public AllSupplierPaymentDetails()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
        
        private void RUNTIMEBINDING()
        {

            SqlDataAdapter AD = new SqlDataAdapter("SELECT*FROM VW_SUPPLIERWISEPAYMENTDETAILS ", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);
            CON.Open();
            if (DS.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void AllSupplierPaymentDetails_Load(object sender, EventArgs e)
        {
            RUNTIMEBINDING();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
