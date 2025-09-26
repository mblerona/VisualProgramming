namespace CashAccountK1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddToSmetka = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDanok = new System.Windows.Forms.NumericUpDown();
            this.tbtoPay = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnDeleteStavka = new System.Windows.Forms.Button();
            this.lbStavki = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToSmetka);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.lbProducts);
            this.groupBox1.Location = new System.Drawing.Point(31, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 699);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // btnAddToSmetka
            // 
            this.btnAddToSmetka.Enabled = false;
            this.btnAddToSmetka.Location = new System.Drawing.Point(25, 530);
            this.btnAddToSmetka.Name = "btnAddToSmetka";
            this.btnAddToSmetka.Size = new System.Drawing.Size(407, 48);
            this.btnAddToSmetka.TabIndex = 4;
            this.btnAddToSmetka.Text = "Add To Smetka";
            this.btnAddToSmetka.UseVisualStyleBackColor = true;
            this.btnAddToSmetka.Click += new System.EventHandler(this.btnAddToSmetka_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(25, 609);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(407, 47);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(120, 475);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(312, 31);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 25;
            this.lbProducts.Location = new System.Drawing.Point(25, 41);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(407, 404);
            this.lbProducts.TabIndex = 1;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudDanok);
            this.groupBox2.Controls.Add(this.tbtoPay);
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.btnDeleteStavka);
            this.groupBox2.Controls.Add(this.lbStavki);
            this.groupBox2.Location = new System.Drawing.Point(643, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 682);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Smetka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "To Pay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danok:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total:";
            // 
            // nudDanok
            // 
            this.nudDanok.Location = new System.Drawing.Point(171, 568);
            this.nudDanok.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDanok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDanok.Name = "nudDanok";
            this.nudDanok.Size = new System.Drawing.Size(257, 31);
            this.nudDanok.TabIndex = 5;
            this.nudDanok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDanok.ValueChanged += new System.EventHandler(this.nudDanok_ValueChanged);
            // 
            // tbtoPay
            // 
            this.tbtoPay.Enabled = false;
            this.tbtoPay.Location = new System.Drawing.Point(171, 625);
            this.tbtoPay.Name = "tbtoPay";
            this.tbtoPay.Size = new System.Drawing.Size(257, 31);
            this.tbtoPay.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(162, 509);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(266, 31);
            this.tbTotal.TabIndex = 7;
            // 
            // btnDeleteStavka
            // 
            this.btnDeleteStavka.Enabled = false;
            this.btnDeleteStavka.Location = new System.Drawing.Point(21, 451);
            this.btnDeleteStavka.Name = "btnDeleteStavka";
            this.btnDeleteStavka.Size = new System.Drawing.Size(407, 43);
            this.btnDeleteStavka.TabIndex = 5;
            this.btnDeleteStavka.Text = "Delete Item";
            this.btnDeleteStavka.UseVisualStyleBackColor = true;
            this.btnDeleteStavka.Click += new System.EventHandler(this.btnDeleteStavka_Click);
            // 
            // lbStavki
            // 
            this.lbStavki.FormattingEnabled = true;
            this.lbStavki.ItemHeight = 25;
            this.lbStavki.Location = new System.Drawing.Point(21, 30);
            this.lbStavki.Name = "lbStavki";
            this.lbStavki.Size = new System.Drawing.Size(407, 404);
            this.lbStavki.TabIndex = 0;
            this.lbStavki.SelectedIndexChanged += new System.EventHandler(this.lbStavki_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 746);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbStavki;
        private System.Windows.Forms.Button btnAddToSmetka;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDanok;
        private System.Windows.Forms.TextBox tbtoPay;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnDeleteStavka;
    }
}

