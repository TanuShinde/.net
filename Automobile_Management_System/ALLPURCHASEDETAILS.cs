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
    public partial class ALLPURCHASEDETAILS : Form
    {
        SqlConnection CON = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Auto"].ToString());
       
        public ALLPURCHASEDETAILS()
        {
            InitializeComponent();
        }

        private void ALLPURCHASEDETAILS_Load(object sender, EventArgs e)
        {
            SqlDataAdapter AD = new SqlDataAdapter("SELECT *FROM VW_PURCHASE ", CON);
            DataSet DS = new DataSet();
            AD.Fill(DS);
            CON.Open();
            if (DS.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
