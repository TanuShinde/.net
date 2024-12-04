namespace Automobile_Management_System
{
    partial class Product
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
            this.PRICE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.COMPANYNAME = new System.Windows.Forms.TextBox();
            this.PRODUCTNAME = new System.Windows.Forms.TextBox();
            this.PRODUCTID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QUANTITY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PRICE
            // 
            this.PRICE.Location = new System.Drawing.Point(318, 246);
            this.PRICE.Margin = new System.Windows.Forms.Padding(4);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(167, 22);
            this.PRICE.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "PRICE";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(318, 81);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 52);
            this.listBox1.TabIndex = 21;
            this.listBox1.Visible = false;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(564, 53);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 32);
            this.search.TabIndex = 20;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.Location = new System.Drawing.Point(570, 293);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 40);
            this.save.TabIndex = 18;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // COMPANYNAME
            // 
            this.COMPANYNAME.Location = new System.Drawing.Point(318, 183);
            this.COMPANYNAME.Margin = new System.Windows.Forms.Padding(4);
            this.COMPANYNAME.Name = "COMPANYNAME";
            this.COMPANYNAME.Size = new System.Drawing.Size(167, 22);
            this.COMPANYNAME.TabIndex = 17;
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.Location = new System.Drawing.Point(318, 57);
            this.PRODUCTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            this.PRODUCTNAME.Size = new System.Drawing.Size(221, 22);
            this.PRODUCTNAME.TabIndex = 16;
            this.PRODUCTNAME.TextChanged += new System.EventHandler(this.PRODUCTNAME_TextChanged);
            this.PRODUCTNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PRODUCTNAME_KeyDown);
            // 
            // PRODUCTID
            // 
            this.PRODUCTID.Location = new System.Drawing.Point(316, 127);
            this.PRODUCTID.Margin = new System.Windows.Forms.Padding(4);
            this.PRODUCTID.Name = "PRODUCTID";
            this.PRODUCTID.ReadOnly = true;
            this.PRODUCTID.Size = new System.Drawing.Size(169, 22);
            this.PRODUCTID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "COMPANY NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "PRODUCT NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRODUCT ID";
            // 
            // QUANTITY
            // 
            this.QUANTITY.Location = new System.Drawing.Point(318, 308);
            this.QUANTITY.Margin = new System.Windows.Forms.Padding(4);
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(167, 22);
            this.QUANTITY.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "QUANTITY";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(827, 455);
            this.Controls.Add(this.QUANTITY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PRICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.save);
            this.Controls.Add(this.COMPANYNAME);
            this.Controls.Add(this.PRODUCTNAME);
            this.Controls.Add(this.PRODUCTID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PRICE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox COMPANYNAME;
        private System.Windows.Forms.TextBox PRODUCTNAME;
        private System.Windows.Forms.TextBox PRODUCTID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QUANTITY;
        private System.Windows.Forms.Label label5;
    }
}