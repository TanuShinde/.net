namespace Automobile_Management_System
{
    partial class Customerpayment
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
            this.lbtranno = new System.Windows.Forms.Label();
            this.TRANSACTIONNO = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.REMAININGPAYMENT = new System.Windows.Forms.TextBox();
            this.PAIDAMOUNT = new System.Windows.Forms.TextBox();
            this.TOTALAMOUNT = new System.Windows.Forms.TextBox();
            this.CUSTOMERNAME = new System.Windows.Forms.TextBox();
            this.CUSTOMERID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymenttype = new System.Windows.Forms.ComboBox();
            this.X = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtranno
            // 
            this.lbtranno.AutoSize = true;
            this.lbtranno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtranno.Location = new System.Drawing.Point(552, 347);
            this.lbtranno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtranno.Name = "lbtranno";
            this.lbtranno.Size = new System.Drawing.Size(157, 20);
            this.lbtranno.TabIndex = 40;
            this.lbtranno.Text = "TRANSACTION NO";
            this.lbtranno.Visible = false;
            this.lbtranno.Click += new System.EventHandler(this.label8_Click);
            // 
            // TRANSACTIONNO
            // 
            this.TRANSACTIONNO.Location = new System.Drawing.Point(730, 347);
            this.TRANSACTIONNO.Margin = new System.Windows.Forms.Padding(4);
            this.TRANSACTIONNO.Name = "TRANSACTIONNO";
            this.TRANSACTIONNO.Size = new System.Drawing.Size(203, 22);
            this.TRANSACTIONNO.TabIndex = 39;
            this.TRANSACTIONNO.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(364, 119);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 52);
            this.listBox1.TabIndex = 38;
            this.listBox1.Visible = false;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(646, 88);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 43);
            this.search.TabIndex = 37;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(649, 382);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 43);
            this.save.TabIndex = 35;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // REMAININGPAYMENT
            // 
            this.REMAININGPAYMENT.Location = new System.Drawing.Point(364, 300);
            this.REMAININGPAYMENT.Margin = new System.Windows.Forms.Padding(4);
            this.REMAININGPAYMENT.Name = "REMAININGPAYMENT";
            this.REMAININGPAYMENT.Size = new System.Drawing.Size(178, 22);
            this.REMAININGPAYMENT.TabIndex = 33;
            // 
            // PAIDAMOUNT
            // 
            this.PAIDAMOUNT.Location = new System.Drawing.Point(364, 251);
            this.PAIDAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.PAIDAMOUNT.Name = "PAIDAMOUNT";
            this.PAIDAMOUNT.Size = new System.Drawing.Size(178, 22);
            this.PAIDAMOUNT.TabIndex = 32;
            this.PAIDAMOUNT.TextChanged += new System.EventHandler(this.PAIDAMOUNT_TextChanged);
            // 
            // TOTALAMOUNT
            // 
            this.TOTALAMOUNT.Location = new System.Drawing.Point(364, 205);
            this.TOTALAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TOTALAMOUNT.Name = "TOTALAMOUNT";
            this.TOTALAMOUNT.Size = new System.Drawing.Size(178, 22);
            this.TOTALAMOUNT.TabIndex = 31;
            this.TOTALAMOUNT.TextChanged += new System.EventHandler(this.TOTALAMOUNT_TextChanged);
            // 
            // CUSTOMERNAME
            // 
            this.CUSTOMERNAME.Location = new System.Drawing.Point(364, 92);
            this.CUSTOMERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.CUSTOMERNAME.Name = "CUSTOMERNAME";
            this.CUSTOMERNAME.Size = new System.Drawing.Size(265, 22);
            this.CUSTOMERNAME.TabIndex = 30;
            this.CUSTOMERNAME.TextChanged += new System.EventHandler(this.CUSTOMERNAME_TextChanged);
            this.CUSTOMERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CUSTOMERNAME_KeyDown);
            // 
            // CUSTOMERID
            // 
            this.CUSTOMERID.Location = new System.Drawing.Point(364, 157);
            this.CUSTOMERID.Margin = new System.Windows.Forms.Padding(4);
            this.CUSTOMERID.Name = "CUSTOMERID";
            this.CUSTOMERID.ReadOnly = true;
            this.CUSTOMERID.Size = new System.Drawing.Size(92, 22);
            this.CUSTOMERID.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 395);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "PAYMENT DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "PAYMENT TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "REMAINING PAYMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "PAID AMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "TOTAL REMAINING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "CUSTOMER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "CUSTOMER ID";
            // 
            // paymenttype
            // 
            this.paymenttype.FormattingEnabled = true;
            this.paymenttype.Items.AddRange(new object[] {
            "CASH",
            "ONLINE"});
            this.paymenttype.Location = new System.Drawing.Point(364, 347);
            this.paymenttype.Margin = new System.Windows.Forms.Padding(4);
            this.paymenttype.Name = "paymenttype";
            this.paymenttype.Size = new System.Drawing.Size(178, 24);
            this.paymenttype.TabIndex = 34;
            this.paymenttype.SelectedIndexChanged += new System.EventHandler(this.paymenttype_SelectedIndexChanged);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Red;
            this.X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.White;
            this.X.Location = new System.Drawing.Point(968, -6);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(33, 33);
            this.X.TabIndex = 101;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 26);
            this.label10.TabIndex = 102;
            this.label10.Text = "CUSTOMER PAYMENT";
            // 
            // Customerpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1003, 532);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.X);
            this.Controls.Add(this.lbtranno);
            this.Controls.Add(this.TRANSACTIONNO);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.save);
            this.Controls.Add(this.paymenttype);
            this.Controls.Add(this.REMAININGPAYMENT);
            this.Controls.Add(this.PAIDAMOUNT);
            this.Controls.Add(this.TOTALAMOUNT);
            this.Controls.Add(this.CUSTOMERNAME);
            this.Controls.Add(this.CUSTOMERID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customerpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customerpayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtranno;
        private System.Windows.Forms.TextBox TRANSACTIONNO;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox REMAININGPAYMENT;
        private System.Windows.Forms.TextBox PAIDAMOUNT;
        private System.Windows.Forms.TextBox TOTALAMOUNT;
        private System.Windows.Forms.TextBox CUSTOMERNAME;
        private System.Windows.Forms.TextBox CUSTOMERID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox paymenttype;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Label label10;
    }
}