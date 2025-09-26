using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f1Race
{
    public partial class NewDriverForm : Form
    {

         public Driver Driver;
        public NewDriverForm()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Must add name ");
                e.Cancel = true;

            }

            else {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Driver = new Driver(tbName.Text, (int)nudAge.Value, cbIsFirst.Checked);
            this.DialogResult = DialogResult.OK;    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void cbIsFirst_Click(object sender, EventArgs e)
        {

        }

        private void cbIsFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsFirst.Checked)
            {
                cbIsFirst.CheckState = CheckState.Checked;

            }
            else {
                cbIsFirst.CheckState = CheckState.Unchecked;
            }
        }

        private void NewDriverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
