namespace Automobile_Management_System
{
    partial class Supplier
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
            this.GSTNO = new System.Windows.Forms.TextBox();
            this.ADDRESS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CONTACTNO = new System.Windows.Forms.TextBox();
            this.SUPPLIERNAME = new System.Windows.Forms.TextBox();
            this.COMPANYNAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SUPPLIERID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GSTNO
            // 
            this.GSTNO.Location = new System.Drawing.Point(338, 407);
            this.GSTNO.Margin = new System.Windows.Forms.Padding(4);
            this.GSTNO.Name = "GSTNO";
            this.GSTNO.Size = new System.Drawing.Size(181, 22);
            this.GSTNO.TabIndex = 30;
            // 
            // ADDRESS
            // 
            this.ADDRESS.Location = new System.Drawing.Point(337, 287);
            this.ADDRESS.Margin = new System.Windows.Forms.Padding(4);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(181, 22);
            this.ADDRESS.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(201, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "GST NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(188, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "ADDRESS";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(591, 86);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(129, 48);
            this.search.TabIndex = 26;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.Location = new System.Drawing.Point(591, 382);
            this.BTNSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(129, 48);
            this.BTNSAVE.TabIndex = 25;
            this.BTNSAVE.Text = "SAVE";
            this.BTNSAVE.UseVisualStyleBackColor = false;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(336, 114);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 116);
            this.listBox1.TabIndex = 24;
            this.listBox1.Visible = false;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // CONTACTNO
            // 
            this.CONTACTNO.Location = new System.Drawing.Point(338, 346);
            this.CONTACTNO.Margin = new System.Windows.Forms.Padding(4);
            this.CONTACTNO.Name = "CONTACTNO";
            this.CONTACTNO.Size = new System.Drawing.Size(180, 22);
            this.CONTACTNO.TabIndex = 23;
            // 
            // SUPPLIERNAME
            // 
            this.SUPPLIERNAME.Location = new System.Drawing.Point(335, 89);
            this.SUPPLIERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.SUPPLIERNAME.Name = "SUPPLIERNAME";
            this.SUPPLIERNAME.Size = new System.Drawing.Size(223, 22);
            this.SUPPLIERNAME.TabIndex = 22;
            this.SUPPLIERNAME.TextChanged += new System.EventHandler(this.SUPPLIERNAME_TextChanged);
            this.SUPPLIERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SUPPLIERNAME_KeyDown);
            // 
            // COMPANYNAME
            // 
            this.COMPANYNAME.Location = new System.Drawing.Point(337, 225);
            this.COMPANYNAME.Margin = new System.Windows.Forms.Padding(4);
            this.COMPANYNAME.Name = "COMPANYNAME";
            this.COMPANYNAME.Size = new System.Drawing.Size(182, 22);
            this.COMPANYNAME.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(149, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "CONTACT NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(110, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "SUPPLIER NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(136, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "COMPANYNAME";
            // 
            // SUPPLIERID
            // 
            this.SUPPLIERID.Location = new System.Drawing.Point(337, 165);
            this.SUPPLIERID.Margin = new System.Windows.Forms.Padding(4);
            this.SUPPLIERID.Name = "SUPPLIERID";
            this.SUPPLIERID.Size = new System.Drawing.Size(181, 22);
            this.SUPPLIERID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(136, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "SUPPLIER ID";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 554);
            this.Controls.Add(this.GSTNO);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.BTNSAVE);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CONTACTNO);
            this.Controls.Add(this.SUPPLIERNAME);
            this.Controls.Add(this.COMPANYNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SUPPLIERID);
            this.Controls.Add(this.label1);
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GSTNO;
        private System.Windows.Forms.TextBox ADDRESS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CONTACTNO;
        private System.Windows.Forms.TextBox SUPPLIERNAME;
        private System.Windows.Forms.TextBox COMPANYNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SUPPLIERID;
        private System.Windows.Forms.Label label1;
    }
}