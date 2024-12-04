namespace Automobile_Management_System
{
    partial class Servicing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CUSTOMERNAME = new System.Windows.Forms.TextBox();
            this.CUSTOMERID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VNAMEANDMODEL = new System.Windows.Forms.TextBox();
            this.RATE = new System.Windows.Forms.TextBox();
            this.QUANTITY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SERVICECHARGE = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TOTALAMOUNT = new System.Windows.Forms.TextBox();
            this.aUTOMOBILEDataSet1 = new Automobile_Management_System.AUTOMOBILEDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Automobile_Management_System.AUTOMOBILEDataSet1TableAdapters.productTableAdapter();
            this.search = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.LBPRODUCTNAME = new System.Windows.Forms.ListBox();
            this.PRODUCTID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOMOBILEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(338, 116);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 52);
            this.listBox1.TabIndex = 44;
            this.listBox1.Visible = false;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // CUSTOMERNAME
            // 
            this.CUSTOMERNAME.Location = new System.Drawing.Point(338, 90);
            this.CUSTOMERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.CUSTOMERNAME.Name = "CUSTOMERNAME";
            this.CUSTOMERNAME.Size = new System.Drawing.Size(245, 22);
            this.CUSTOMERNAME.TabIndex = 42;
            this.CUSTOMERNAME.TextChanged += new System.EventHandler(this.CUSTOMERNAME_TextChanged);
            this.CUSTOMERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CUSTOMERNAME_KeyDown);
            // 
            // CUSTOMERID
            // 
            this.CUSTOMERID.Location = new System.Drawing.Point(338, 158);
            this.CUSTOMERID.Margin = new System.Windows.Forms.Padding(4);
            this.CUSTOMERID.Name = "CUSTOMERID";
            this.CUSTOMERID.ReadOnly = true;
            this.CUSTOMERID.Size = new System.Drawing.Size(245, 22);
            this.CUSTOMERID.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "CUSTOMER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "CUSTOMER ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "VECHICLE NAME AND MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "PRODUCTNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "RATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "QUANTITY";
            // 
            // VNAMEANDMODEL
            // 
            this.VNAMEANDMODEL.Location = new System.Drawing.Point(338, 210);
            this.VNAMEANDMODEL.Margin = new System.Windows.Forms.Padding(4);
            this.VNAMEANDMODEL.Name = "VNAMEANDMODEL";
            this.VNAMEANDMODEL.Size = new System.Drawing.Size(245, 22);
            this.VNAMEANDMODEL.TabIndex = 49;
            // 
            // RATE
            // 
            this.RATE.Location = new System.Drawing.Point(342, 356);
            this.RATE.Margin = new System.Windows.Forms.Padding(4);
            this.RATE.Name = "RATE";
            this.RATE.Size = new System.Drawing.Size(239, 22);
            this.RATE.TabIndex = 51;
            this.RATE.TextChanged += new System.EventHandler(this.RATE_TextChanged);
            // 
            // QUANTITY
            // 
            this.QUANTITY.Location = new System.Drawing.Point(342, 398);
            this.QUANTITY.Margin = new System.Windows.Forms.Padding(4);
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(241, 22);
            this.QUANTITY.TabIndex = 52;
            this.QUANTITY.TextChanged += new System.EventHandler(this.QUANTITY_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 433);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "SERVICE CHARGE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(147, 473);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "SERVICING DATE";
            // 
            // SERVICECHARGE
            // 
            this.SERVICECHARGE.Location = new System.Drawing.Point(342, 438);
            this.SERVICECHARGE.Margin = new System.Windows.Forms.Padding(4);
            this.SERVICECHARGE.Name = "SERVICECHARGE";
            this.SERVICECHARGE.Size = new System.Drawing.Size(241, 22);
            this.SERVICECHARGE.TabIndex = 55;
            this.SERVICECHARGE.TextChanged += new System.EventHandler(this.SERVICECHARGE_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 478);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(152, 521);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "TOTAL AMOUNT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(338, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 29);
            this.label10.TabIndex = 58;
            this.label10.Text = "SERVICING ";
            // 
            // TOTALAMOUNT
            // 
            this.TOTALAMOUNT.Location = new System.Drawing.Point(338, 524);
            this.TOTALAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TOTALAMOUNT.Name = "TOTALAMOUNT";
            this.TOTALAMOUNT.Size = new System.Drawing.Size(245, 22);
            this.TOTALAMOUNT.TabIndex = 59;
            this.TOTALAMOUNT.TextChanged += new System.EventHandler(this.TOTALAMOUNT_TextChanged);
            // 
            // aUTOMOBILEDataSet1
            // 
            this.aUTOMOBILEDataSet1.DataSetName = "AUTOMOBILEDataSet1";
            this.aUTOMOBILEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.aUTOMOBILEDataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.search.Location = new System.Drawing.Point(619, 92);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 40);
            this.search.TabIndex = 61;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SAVE.Location = new System.Drawing.Point(628, 506);
            this.SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(100, 40);
            this.SAVE.TabIndex = 62;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(335, 252);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(248, 22);
            this.ProductName.TabIndex = 83;
            this.ProductName.TextChanged += new System.EventHandler(this.ProductName_TextChanged);
            this.ProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // LBPRODUCTNAME
            // 
            this.LBPRODUCTNAME.FormattingEnabled = true;
            this.LBPRODUCTNAME.ItemHeight = 16;
            this.LBPRODUCTNAME.Location = new System.Drawing.Point(335, 277);
            this.LBPRODUCTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.LBPRODUCTNAME.Name = "LBPRODUCTNAME";
            this.LBPRODUCTNAME.Size = new System.Drawing.Size(248, 52);
            this.LBPRODUCTNAME.TabIndex = 84;
            this.LBPRODUCTNAME.Visible = false;
            this.LBPRODUCTNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox2_KeyPress);
            // 
            // PRODUCTID
            // 
            this.PRODUCTID.Location = new System.Drawing.Point(335, 315);
            this.PRODUCTID.Margin = new System.Windows.Forms.Padding(4);
            this.PRODUCTID.Name = "PRODUCTID";
            this.PRODUCTID.ReadOnly = true;
            this.PRODUCTID.Size = new System.Drawing.Size(248, 22);
            this.PRODUCTID.TabIndex = 85;
            //this.PRODUCTID.TextChanged += new System.EventHandler(this.PRODUCTID_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(196, 313);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 24);
            this.label11.TabIndex = 86;
            this.label11.Text = "PRODUCT ID";
            // 
            // Servicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(841, 631);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PRODUCTID);
            this.Controls.Add(this.LBPRODUCTNAME);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.search);
            this.Controls.Add(this.TOTALAMOUNT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SERVICECHARGE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QUANTITY);
            this.Controls.Add(this.RATE);
            this.Controls.Add(this.VNAMEANDMODEL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CUSTOMERNAME);
            this.Controls.Add(this.CUSTOMERID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Servicing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicing";
            this.Load += new System.EventHandler(this.Servicing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTOMOBILEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CUSTOMERNAME;
        private System.Windows.Forms.TextBox CUSTOMERID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VNAMEANDMODEL;
        private System.Windows.Forms.TextBox RATE;
        private System.Windows.Forms.TextBox QUANTITY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SERVICECHARGE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TOTALAMOUNT;
        private AUTOMOBILEDataSet1 aUTOMOBILEDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AUTOMOBILEDataSet1TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.ListBox LBPRODUCTNAME;
        private System.Windows.Forms.TextBox PRODUCTID;
        private System.Windows.Forms.Label label11;
    }
}