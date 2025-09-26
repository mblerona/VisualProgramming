using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class NewOrderForm : Form
    {

        public Order Order { get; set; }
        public NewOrderForm()
        {
            InitializeComponent();
            cbProducts.Items.Add(new Product("Milk", 120));
            cbProducts.Items.Add(new Product("Bread", 40));
            cbProducts.Items.Add(new Product("Water", 50));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedIndex != -1) { 
            Product product = cbProducts.SelectedItem as Product;
            this.Order= new Order(product,(int)nudQuantity.Value, tbZabeleska.Text);
            this.DialogResult = DialogResult.OK;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel; 
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbProducts.SelectedIndex != -1)
            {
                btnSave.Enabled = true;
            }
        }
    }
}
