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
    public partial class NewProduct : Form
    {

        public Product Product { get; set; }
        public NewProduct()
        {
            InitializeComponent();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "") {
                productEP.SetError(tbName, "Must not be empty");
                e.Cancel = true;
            }
            else
            {
                productEP.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int price = int.Parse(tbPrice.Text);
            this.Product = new Product(tbName.Text, tbCategory.Text,price);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
