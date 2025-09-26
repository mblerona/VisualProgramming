using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid1_Task1
{
    public partial class BusForm : Form
    {

        public Bus Bus; 
        public BusForm()
        {
            InitializeComponent();
        }

        private void BusForm_Load(object sender, EventArgs e)
        {

        }

        private void cbisLocal_CheckedChanged(object sender, EventArgs e)
        {
          
            if (cbisLocal.Checked)
            {
                cbisLocal.CheckState = CheckState.Checked;
            }
            else {
                cbisLocal.CheckState = CheckState.Unchecked;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Bus = new Bus(tbRegistration.Text, tbName.Text, cbisLocal.Checked ? true : false);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
