using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferencePapersK1
{
    public partial class NewConference : Form
    {

        public Conference Conference;


        public NewConference()
        {
            InitializeComponent();
        }

        private void NewConference_Load(object sender, EventArgs e)
        {
           
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Must add name");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.Conference = new Conference(tbName.Text, (int)nudYear.Value);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
