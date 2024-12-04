using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automobile_Management_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        
        private void pRODUCTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product A = new Product();
            A.ShowDialog();
        }

        private void nEWSUPPLIERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier A = new Supplier();
            A.ShowDialog();
        }

        private void sUPPLIERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplierpayment A = new Supplierpayment();
            A.ShowDialog();

        }

      
        private void aLLSUPPLIERPAYMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSupplierPaymentDetails A = new AllSupplierPaymentDetails();
            A.ShowDialog();
        }

        private void sUPPLIERWISEPAYMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierwisePaymentdetails A = new SupplierwisePaymentdetails();
            A.ShowDialog();
        }

        private void nEWPURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase A = new Purchase();
            A.ShowDialog();
        }

        private void aLLSTOCKDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllStock A = new AllStock();
            A.ShowDialog();
        }

        private void aLLPAYMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCustomerPaymentDetails A = new AllCustomerPaymentDetails();
            A.ShowDialog();
        }

        private void cUSTOMERWISEPAYMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customerpaymentdetails A = new Customerpaymentdetails();
            A.ShowDialog();
        }

        private void nEWUSERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewUser A = new NewUser();
            A.ShowDialog();
        }

        private void nEWSERVICINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicing A = new Servicing();
            A.ShowDialog();
        }

        private void pRODUCTWISESTOCKDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductwiseStockDetails a = new ProductwiseStockDetails();
            a.ShowDialog();
        }

        private void cUSTOMERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customerpayment A = new Customerpayment();
            A.ShowDialog();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierwisePurchaseDetails a = new SupplierwisePurchaseDetails();
            a.ShowDialog();
        }

        private void pRODUCTWISEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductwisePurchase a = new ProductwisePurchase();
            a.ShowDialog();
        }

        private void cUSTOMERWISESERVICINGDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerwiseServicingDetails a = new CustomerwiseServicingDetails();
            a.ShowDialog();
        
        }

        private void aLLSERVICINGDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALLSERVICINGDETAILS A = new ALLSERVICINGDETAILS();
            A.ShowDialog();
        }

        private void aLLSUPPLIERWISEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALLPURCHASEDETAILS A = new ALLPURCHASEDETAILS();
            A.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nEWCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer a = new Customer();
            a.ShowDialog();

        }

        
        
    }
}
