using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {

        public Cart cart;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            newProduct.ShowDialog();
            if(newProduct.DialogResult == DialogResult.OK)
            {
                lbProducts.Items.Add(newProduct.Product);

            }


        }


        private void loadInfo() {
            if (lbProducts.SelectedIndex != -1)
            {
                Product selectedProcuct = lbProducts.SelectedItem as Product;
                tbName.Text = selectedProcuct.Name;
                tbPrice.Text = selectedProcuct.Price.ToString();
                tbCategory.Text = selectedProcuct.Category;
            }
        
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void lbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(lbProducts.SelectedIndex != -1)
            {
                Product product = lbProducts.SelectedItem as Product;
                lbProducts.Items.Remove(product);

            }
        }

        private void btnEmptyProductList_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Aree you sure you want to empty list?", "Empty Product List", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK) { 
               lbProducts.Items.Clear();
                tbName.Clear();
                tbCategory.Clear();
                tbPrice.Clear();

            }
            else
            {
                dg=DialogResult.Cancel;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbProducts.Items.Add(new Product("Milk", "Drink", 100) as Product);
            lbProducts.Items.Add(new Product("Chocolate", "Snack", 80) as Product);
            lbProducts.Items.Add(new Product("Bread", "Food", 65) as Product);
            lbProducts.Items.Add(new Product("Juice", "Drink", 170) as Product);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
          
            if(lbProducts.SelectedIndex != -1)
            {
                Product product = lbProducts.SelectedItem as Product;

                lbCart.Items.Add(product);
                totalSum();
            }

    
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbCart.SelectedIndex != -1) { 
            lbCart.Items.Remove(lbCart.SelectedItem as Product);
                totalSum();
            }
        }


        private void totalSum() {

            int total = 0;
            for (int i = 0; i < lbCart.Items.Count; i++)
            {
            Product p = lbCart.Items[i] as Product;
               total += (int)p.Price;
            }
            tbTotal.Text = total.ToString("0.00");

        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to empty cart?", " Sure ", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                lbCart.Items.Clear();
                totalSum();
            }
            else {
                dg = DialogResult.Cancel;
            }
        }
    }
}
