namespace Automobile_Management_System
{
    partial class Customer
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
            this.SEARCH = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MOBILENO = new System.Windows.Forms.TextBox();
            this.CUSTOMERNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CUSTOMERID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SEARCH
            // 
            this.SEARCH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SEARCH.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SEARCH.Location = new System.Drawing.Point(634, 77);
            this.SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(131, 50);
            this.SEARCH.TabIndex = 23;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = false;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 112);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 68);
            this.listBox1.TabIndex = 22;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(142, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "MOBILE NO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MOBILENO
            // 
            this.MOBILENO.Location = new System.Drawing.Point(292, 214);
            this.MOBILENO.Margin = new System.Windows.Forms.Padding(4);
            this.MOBILENO.MaxLength = 10;
            this.MOBILENO.Name = "MOBILENO";
            this.MOBILENO.Size = new System.Drawing.Size(291, 22);
            this.MOBILENO.TabIndex = 18;
            // 
            // CUSTOMERNAME
            // 
            this.CUSTOMERNAME.Location = new System.Drawing.Point(292, 87);
            this.CUSTOMERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.CUSTOMERNAME.Name = "CUSTOMERNAME";
            this.CUSTOMERNAME.Size = new System.Drawing.Size(291, 22);
            this.CUSTOMERNAME.TabIndex = 17;
            this.CUSTOMERNAME.TextChanged += new System.EventHandler(this.CUSTOMERNAME_TextChanged);
            this.CUSTOMERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CUSTOMERNAME_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "CUSTOMER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(116, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "CUSTOMER ID";
            // 
            // CUSTOMERID
            // 
            this.CUSTOMERID.Location = new System.Drawing.Point(292, 147);
            this.CUSTOMERID.Margin = new System.Windows.Forms.Padding(4);
            this.CUSTOMERID.Name = "CUSTOMERID";
            this.CUSTOMERID.ReadOnly = true;
            this.CUSTOMERID.Size = new System.Drawing.Size(291, 22);
            this.CUSTOMERID.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(634, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SAVE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SAVE.Location = new System.Drawing.Point(634, 137);
            this.SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(131, 50);
            this.SAVE.TabIndex = 12;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(329, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "NEW CUSTOMER ";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(877, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MOBILENO);
            this.Controls.Add(this.CUSTOMERNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CUSTOMERID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SAVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MOBILENO;
        private System.Windows.Forms.TextBox CUSTOMERNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CUSTOMERID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Label label4;
    }
}