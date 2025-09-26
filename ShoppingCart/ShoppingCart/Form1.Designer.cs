namespace ShoppingCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnEmptyProductList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products List";
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 25;
            this.lbProducts.Location = new System.Drawing.Point(50, 98);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(460, 704);
            this.lbProducts.TabIndex = 1;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            this.lbProducts.SelectedValueChanged += new System.EventHandler(this.lbProducts_SelectedValueChanged);
            // 
            // btnEmptyProductList
            // 
            this.btnEmptyProductList.Location = new System.Drawing.Point(50, 846);
            this.btnEmptyProductList.Name = "btnEmptyProductList";
            this.btnEmptyProductList.Size = new System.Drawing.Size(460, 40);
            this.btnEmptyProductList.TabIndex = 2;
            this.btnEmptyProductList.Text = "Empty Product List";
            this.btnEmptyProductList.UseVisualStyleBackColor = true;
            this.btnEmptyProductList.Click += new System.EventHandler(this.btnEmptyProductList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnAddNewProduct);
            this.groupBox1.Controls.Add(this.btnRemoveFromCart);
            this.groupBox1.Controls.Add(this.btnAddToCart);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbCategory);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(552, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 704);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(38, 616);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(506, 45);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(38, 548);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(506, 45);
            this.btnAddNewProduct.TabIndex = 8;
            this.btnAddNewProduct.Text = "Add new Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(38, 470);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(506, 45);
            this.btnRemoveFromCart.TabIndex = 7;
            this.btnRemoveFromCart.Text = "Remove from Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(38, 405);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(506, 45);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.AcceptsReturn = true;
            this.tbPrice.Enabled = false;
            this.tbPrice.Location = new System.Drawing.Point(38, 290);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(506, 31);
            this.tbPrice.TabIndex = 5;
            // 
            // tbCategory
            // 
            this.tbCategory.Enabled = false;
            this.tbCategory.Location = new System.Drawing.Point(38, 200);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(506, 31);
            this.tbCategory.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(38, 108);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(506, 31);
            this.tbName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1241, 825);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1241, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cart:";
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 25;
            this.lbCart.Location = new System.Drawing.Point(1237, 110);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(452, 679);
            this.lbCart.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(1313, 819);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(326, 31);
            this.tbTotal.TabIndex = 10;
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(1237, 877);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(452, 45);
            this.btnEmptyCart.TabIndex = 10;
            this.btnEmptyCart.Text = "Empty Cart";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.btnEmptyCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 944);
            this.Controls.Add(this.btnEmptyCart);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEmptyProductList);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btnEmptyProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnEmptyCart;
    }
}

