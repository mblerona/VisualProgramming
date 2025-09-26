using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccountK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();   

            if(newProduct.ShowDialog() == DialogResult.OK) {
                foreach (Product product in lbProducts.Items) {
                    if (product.Code == newProduct.product.Code) {
                        MessageBox.Show("Cannot add product", "Error", MessageBoxButtons.OK);
                        return;
                    }
                
                }
                lbProducts.Items.Add(newProduct.product);
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToSmetka.Enabled = true;
        }

        private void btnAddToSmetka_Click(object sender, EventArgs e)
        {
            if(lbProducts.SelectedIndex == -1) {
                return;
            }

            Product SelectedProdcut  = lbProducts.SelectedItem as Product;
            Stavka createdStavka = new Stavka(SelectedProdcut, (int)nudQuantity.Value);

            lbStavki.Items.Add(createdStavka);
            lbProducts.SelectedIndex = -1;
            btnAddToSmetka.Enabled = false;
            nudQuantity.Value = 1;
            calculateStuff();

        }

        private void btnDeleteStavka_Click(object sender, EventArgs e)
        {
            if (lbStavki.SelectedIndex != -1) {
              DialogResult dg=  MessageBox.Show("Are you sure you want to delete item?", "Delete item", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    lbStavki.Items.RemoveAt(lbStavki.SelectedIndex);
                    btnDeleteStavka.Enabled = false;
                    calculateStuff();
                }
               
            }
        }

        private void lbStavki_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteStavka.Enabled = true;
        }

        private void nudDanok_ValueChanged(object sender, EventArgs e)
        {
            calculateStuff();
        }



        private void calculateStuff() {
            decimal totalsum = 0;
            decimal priceToPay = 1;
            foreach (Stavka stavka in lbStavki.Items)
            {
                totalsum += stavka.totalPrice();

            }

            priceToPay =totalsum+ totalsum * (nudDanok.Value / 100);
            tbTotal.Text = totalsum.ToString();
            tbtoPay.Text = priceToPay.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
