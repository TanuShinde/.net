namespace Automobile_Management_System
{
    partial class Purchase
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
            this.PRODUCTID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbproductname = new System.Windows.Forms.ListBox();
            this.PRODUCTNAME = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PAYMENTTYPE = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ADDRESS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PAIDAMOUNT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TOTALAMOUNT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.QUANTITY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RATE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GSTNO = new System.Windows.Forms.TextBox();
            this.COMPANYNAME = new System.Windows.Forms.TextBox();
            this.SUPPLIERNAME = new System.Windows.Forms.TextBox();
            this.SUPPLIERID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.REMAININGMOUNT = new System.Windows.Forms.TextBox();
            this.MOBILENO = new System.Windows.Forms.TextBox();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PRODUCTID
            // 
            this.PRODUCTID.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCTID.Location = new System.Drawing.Point(797, 279);
            this.PRODUCTID.Margin = new System.Windows.Forms.Padding(4);
            this.PRODUCTID.Name = "PRODUCTID";
            this.PRODUCTID.ReadOnly = true;
            this.PRODUCTID.Size = new System.Drawing.Size(168, 38);
            this.PRODUCTID.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(624, 277);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 32);
            this.label14.TabIndex = 76;
            this.label14.Text = "PRODUCT ID";
            // 
            // lbproductname
            // 
            this.lbproductname.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductname.FormattingEnabled = true;
            this.lbproductname.ItemHeight = 31;
            this.lbproductname.Location = new System.Drawing.Point(312, 321);
            this.lbproductname.Margin = new System.Windows.Forms.Padding(4);
            this.lbproductname.Name = "lbproductname";
            this.lbproductname.Size = new System.Drawing.Size(225, 35);
            this.lbproductname.TabIndex = 75;
            this.lbproductname.Visible = false;
            this.lbproductname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbproductname_KeyPress);
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCTNAME.Location = new System.Drawing.Point(312, 279);
            this.PRODUCTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            this.PRODUCTNAME.Size = new System.Drawing.Size(225, 38);
            this.PRODUCTNAME.TabIndex = 74;
            this.PRODUCTNAME.TextChanged += new System.EventHandler(this.PRODUCTNAME_TextChanged);
            this.PRODUCTNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PRODUCTNAME_KeyDown);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CASH",
            "CHEAQUE"});
            this.comboBox2.Location = new System.Drawing.Point(312, 513);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(183, 39);
            this.comboBox2.TabIndex = 73;
            // 
            // PAYMENTTYPE
            // 
            this.PAYMENTTYPE.AutoSize = true;
            this.PAYMENTTYPE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PAYMENTTYPE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAYMENTTYPE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PAYMENTTYPE.Location = new System.Drawing.Point(58, 514);
            this.PAYMENTTYPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PAYMENTTYPE.Name = "PAYMENTTYPE";
            this.PAYMENTTYPE.Size = new System.Drawing.Size(195, 32);
            this.PAYMENTTYPE.TabIndex = 70;
            this.PAYMENTTYPE.Text = "PAYMENT TYPE";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(520, 55);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 35);
            this.listBox1.TabIndex = 69;
            this.listBox1.Visible = false;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // ADDRESS
            // 
            this.ADDRESS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDRESS.Location = new System.Drawing.Point(1169, 198);
            this.ADDRESS.Margin = new System.Windows.Forms.Padding(4);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            this.ADDRESS.Size = new System.Drawing.Size(132, 34);
            this.ADDRESS.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(1048, 198);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 32);
            this.label13.TabIndex = 67;
            this.label13.Text = "ADDRESS";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.search.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(799, 20);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(145, 42);
            this.search.TabIndex = 66;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(802, 516);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 38);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(594, 516);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 32);
            this.label12.TabIndex = 62;
            this.label12.Text = "PAYMENT DATE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(633, 438);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 32);
            this.label11.TabIndex = 60;
            this.label11.Text = "REMAINING";
            // 
            // PAIDAMOUNT
            // 
            this.PAIDAMOUNT.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAIDAMOUNT.Location = new System.Drawing.Point(311, 441);
            this.PAIDAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.PAIDAMOUNT.Name = "PAIDAMOUNT";
            this.PAIDAMOUNT.Size = new System.Drawing.Size(185, 38);
            this.PAIDAMOUNT.TabIndex = 59;
            this.PAIDAMOUNT.TextChanged += new System.EventHandler(this.PAIDAMOUNT_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(67, 444);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 32);
            this.label10.TabIndex = 58;
            this.label10.Text = "PAID AMOUNT";
            // 
            // TOTALAMOUNT
            // 
            this.TOTALAMOUNT.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTALAMOUNT.Location = new System.Drawing.Point(1169, 364);
            this.TOTALAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TOTALAMOUNT.Name = "TOTALAMOUNT";
            this.TOTALAMOUNT.ReadOnly = true;
            this.TOTALAMOUNT.Size = new System.Drawing.Size(132, 38);
            this.TOTALAMOUNT.TabIndex = 57;
            this.TOTALAMOUNT.TextChanged += new System.EventHandler(this.TOTALAMOUNT_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(973, 368);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 32);
            this.label9.TabIndex = 56;
            this.label9.Text = "TOTAL AMOUNT";
            // 
            // QUANTITY
            // 
            this.QUANTITY.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANTITY.Location = new System.Drawing.Point(797, 366);
            this.QUANTITY.Margin = new System.Windows.Forms.Padding(4);
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(168, 38);
            this.QUANTITY.TabIndex = 55;
            this.QUANTITY.TextChanged += new System.EventHandler(this.QUANTITY_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(652, 370);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 32);
            this.label8.TabIndex = 54;
            this.label8.Text = "QUANTITY";
            // 
            // RATE
            // 
            this.RATE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RATE.Location = new System.Drawing.Point(311, 372);
            this.RATE.Margin = new System.Windows.Forms.Padding(4);
            this.RATE.Name = "RATE";
            this.RATE.Size = new System.Drawing.Size(184, 38);
            this.RATE.TabIndex = 53;
            this.RATE.TextChanged += new System.EventHandler(this.RATE_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(170, 372);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 32);
            this.label7.TabIndex = 52;
            this.label7.Text = "RATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(58, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 51;
            this.label6.Text = "PRODUCT NAME";
            // 
            // GSTNO
            // 
            this.GSTNO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GSTNO.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GSTNO.Location = new System.Drawing.Point(802, 198);
            this.GSTNO.Margin = new System.Windows.Forms.Padding(4);
            this.GSTNO.Name = "GSTNO";
            this.GSTNO.ReadOnly = true;
            this.GSTNO.Size = new System.Drawing.Size(163, 38);
            this.GSTNO.TabIndex = 49;
            // 
            // COMPANYNAME
            // 
            this.COMPANYNAME.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPANYNAME.Location = new System.Drawing.Point(312, 202);
            this.COMPANYNAME.Margin = new System.Windows.Forms.Padding(4);
            this.COMPANYNAME.Name = "COMPANYNAME";
            this.COMPANYNAME.ReadOnly = true;
            this.COMPANYNAME.Size = new System.Drawing.Size(184, 38);
            this.COMPANYNAME.TabIndex = 47;
            // 
            // SUPPLIERNAME
            // 
            this.SUPPLIERNAME.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPLIERNAME.Location = new System.Drawing.Point(518, 16);
            this.SUPPLIERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.SUPPLIERNAME.Name = "SUPPLIERNAME";
            this.SUPPLIERNAME.Size = new System.Drawing.Size(265, 38);
            this.SUPPLIERNAME.TabIndex = 46;
            this.SUPPLIERNAME.TextChanged += new System.EventHandler(this.SUPPLIERNAME_TextChanged);
            this.SUPPLIERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SUPPLIERNAME_KeyDown);
            // 
            // SUPPLIERID
            // 
            this.SUPPLIERID.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPLIERID.Location = new System.Drawing.Point(312, 128);
            this.SUPPLIERID.Margin = new System.Windows.Forms.Padding(4);
            this.SUPPLIERID.Name = "SUPPLIERID";
            this.SUPPLIERID.ReadOnly = true;
            this.SUPPLIERID.Size = new System.Drawing.Size(183, 38);
            this.SUPPLIERID.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(684, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "GST NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(639, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 43;
            this.label4.Text = "MOBILE NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "COMPANY NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(286, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 41;
            this.label2.Text = "SUPPLIER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "SUPPLIERID";
            // 
            // REMAININGMOUNT
            // 
            this.REMAININGMOUNT.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMAININGMOUNT.Location = new System.Drawing.Point(796, 435);
            this.REMAININGMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.REMAININGMOUNT.Name = "REMAININGMOUNT";
            this.REMAININGMOUNT.ReadOnly = true;
            this.REMAININGMOUNT.Size = new System.Drawing.Size(173, 38);
            this.REMAININGMOUNT.TabIndex = 57;
            this.REMAININGMOUNT.TextChanged += new System.EventHandler(this.TOTALAMOUNT_TextChanged);
            // 
            // MOBILENO
            // 
            this.MOBILENO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MOBILENO.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOBILENO.Location = new System.Drawing.Point(806, 123);
            this.MOBILENO.Margin = new System.Windows.Forms.Padding(4);
            this.MOBILENO.Name = "MOBILENO";
            this.MOBILENO.ReadOnly = true;
            this.MOBILENO.Size = new System.Drawing.Size(163, 38);
            this.MOBILENO.TabIndex = 48;
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.Location = new System.Drawing.Point(1054, 508);
            this.BTNSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(150, 48);
            this.BTNSAVE.TabIndex = 79;
            this.BTNSAVE.Text = "SAVE";
            this.BTNSAVE.UseVisualStyleBackColor = false;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1329, 668);
            this.Controls.Add(this.BTNSAVE);
            this.Controls.Add(this.PRODUCTID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbproductname);
            this.Controls.Add(this.PRODUCTNAME);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.PAYMENTTYPE);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PAIDAMOUNT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.REMAININGMOUNT);
            this.Controls.Add(this.TOTALAMOUNT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.QUANTITY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GSTNO);
            this.Controls.Add(this.MOBILENO);
            this.Controls.Add(this.COMPANYNAME);
            this.Controls.Add(this.SUPPLIERNAME);
            this.Controls.Add(this.SUPPLIERID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PRODUCTID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbproductname;
        private System.Windows.Forms.TextBox PRODUCTNAME;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label PAYMENTTYPE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox ADDRESS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PAIDAMOUNT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TOTALAMOUNT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox QUANTITY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RATE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GSTNO;
        private System.Windows.Forms.TextBox COMPANYNAME;
        private System.Windows.Forms.TextBox SUPPLIERNAME;
        private System.Windows.Forms.TextBox SUPPLIERID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox REMAININGMOUNT;
        private System.Windows.Forms.TextBox MOBILENO;
        private System.Windows.Forms.Button BTNSAVE;
    }
}