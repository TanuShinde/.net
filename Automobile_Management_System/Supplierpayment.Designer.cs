namespace Automobile_Management_System
{
    partial class Supplierpayment
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
            this.CHEQUENO = new System.Windows.Forms.TextBox();
            this.lBCHEQUENO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SUPPLIERID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PAIDDATE = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.REMAININGAMOUNT = new System.Windows.Forms.TextBox();
            this.PAIDAMOUNT = new System.Windows.Forms.TextBox();
            this.TOTALAMOUNT = new System.Windows.Forms.TextBox();
            this.SUPPLIERNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CHEQUENO
            // 
            this.CHEQUENO.Location = new System.Drawing.Point(669, 394);
            this.CHEQUENO.Margin = new System.Windows.Forms.Padding(4);
            this.CHEQUENO.Name = "CHEQUENO";
            this.CHEQUENO.Size = new System.Drawing.Size(186, 22);
            this.CHEQUENO.TabIndex = 43;
            this.CHEQUENO.Visible = false;
            // 
            // lBCHEQUENO
            // 
            this.lBCHEQUENO.AutoSize = true;
            this.lBCHEQUENO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBCHEQUENO.Location = new System.Drawing.Point(529, 392);
            this.lBCHEQUENO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBCHEQUENO.Name = "lBCHEQUENO";
            this.lBCHEQUENO.Size = new System.Drawing.Size(125, 24);
            this.lBCHEQUENO.TabIndex = 42;
            this.lBCHEQUENO.Text = "CHEQUE NO";
            this.lBCHEQUENO.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "PAYMENT TYPE";
            // 
            // SUPPLIERID
            // 
            this.SUPPLIERID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SUPPLIERID.Location = new System.Drawing.Point(328, 177);
            this.SUPPLIERID.Margin = new System.Windows.Forms.Padding(4);
            this.SUPPLIERID.Name = "SUPPLIERID";
            this.SUPPLIERID.ReadOnly = true;
            this.SUPPLIERID.Size = new System.Drawing.Size(185, 22);
            this.SUPPLIERID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "SUPPLIER ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 450);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // PAIDDATE
            // 
            this.PAIDDATE.AutoSize = true;
            this.PAIDDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAIDDATE.Location = new System.Drawing.Point(208, 448);
            this.PAIDDATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PAIDDATE.Name = "PAIDDATE";
            this.PAIDDATE.Size = new System.Drawing.Size(103, 24);
            this.PAIDDATE.TabIndex = 36;
            this.PAIDDATE.Text = "PAIDDATE";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(328, 127);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 116);
            this.listBox1.TabIndex = 35;
            this.listBox1.Visible = false;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // REMAININGAMOUNT
            // 
            this.REMAININGAMOUNT.Location = new System.Drawing.Point(328, 350);
            this.REMAININGAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.REMAININGAMOUNT.Name = "REMAININGAMOUNT";
            this.REMAININGAMOUNT.Size = new System.Drawing.Size(185, 22);
            this.REMAININGAMOUNT.TabIndex = 33;
            this.REMAININGAMOUNT.TextChanged += new System.EventHandler(this.REMAININGAMOUNT_TextChanged);
            // 
            // PAIDAMOUNT
            // 
            this.PAIDAMOUNT.Location = new System.Drawing.Point(328, 292);
            this.PAIDAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.PAIDAMOUNT.Name = "PAIDAMOUNT";
            this.PAIDAMOUNT.Size = new System.Drawing.Size(185, 22);
            this.PAIDAMOUNT.TabIndex = 32;
            this.PAIDAMOUNT.TextChanged += new System.EventHandler(this.PAIDAMOUNT_TextChanged);
            // 
            // TOTALAMOUNT
            // 
            this.TOTALAMOUNT.Location = new System.Drawing.Point(328, 236);
            this.TOTALAMOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.TOTALAMOUNT.Name = "TOTALAMOUNT";
            this.TOTALAMOUNT.Size = new System.Drawing.Size(185, 22);
            this.TOTALAMOUNT.TabIndex = 31;
            this.TOTALAMOUNT.TextChanged += new System.EventHandler(this.TOTALAMOUNT_TextChanged);
            // 
            // SUPPLIERNAME
            // 
            this.SUPPLIERNAME.Location = new System.Drawing.Point(328, 99);
            this.SUPPLIERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.SUPPLIERNAME.Name = "SUPPLIERNAME";
            this.SUPPLIERNAME.Size = new System.Drawing.Size(280, 22);
            this.SUPPLIERNAME.TabIndex = 30;
            this.SUPPLIERNAME.TextChanged += new System.EventHandler(this.SUPPLIERNAME_TextChanged);
            this.SUPPLIERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SUPPLIERNAME_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "REMAININGAMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "PAIDAMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "TOTALAMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "SUPPLIERNAME";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(632, 97);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 40);
            this.search.TabIndex = 25;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(632, 435);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 37);
            this.save.TabIndex = 24;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ONLINE",
            "CASH"});
            this.comboBox1.Location = new System.Drawing.Point(328, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Supplierpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(979, 567);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CHEQUENO);
            this.Controls.Add(this.lBCHEQUENO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SUPPLIERID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PAIDDATE);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.REMAININGAMOUNT);
            this.Controls.Add(this.PAIDAMOUNT);
            this.Controls.Add(this.TOTALAMOUNT);
            this.Controls.Add(this.SUPPLIERNAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.save);
            this.Name = "Supplierpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplierpayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CHEQUENO;
        private System.Windows.Forms.Label lBCHEQUENO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SUPPLIERID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label PAIDDATE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox REMAININGAMOUNT;
        private System.Windows.Forms.TextBox PAIDAMOUNT;
        private System.Windows.Forms.TextBox TOTALAMOUNT;
        private System.Windows.Forms.TextBox SUPPLIERNAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}