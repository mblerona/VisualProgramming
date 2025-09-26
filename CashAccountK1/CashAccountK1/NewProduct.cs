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
    public partial class NewProduct : Form
    {

        public Product product;
        public NewProduct()
        {
            InitializeComponent();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void tbname_Validating(object sender, CancelEventArgs e)
        {
            if (tbname.Text == "")
            {
                errorProvider1.SetError(tbname, "Must add Name");
                e.Cancel = true;
            }
            else {

                errorProvider1.SetError(tbname, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) {
                this.product = new Product((int)nudKod.Value, tbname.Text, (int)nudPrice.Value);
                DialogResult = DialogResult.OK;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }
    }
}
