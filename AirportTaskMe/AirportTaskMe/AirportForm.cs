using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportTaskMe
{
    public partial class AirportForm : Form
    {
        public Airport Airport { get; set; }    

        public AirportForm()
        {
            InitializeComponent();
        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text == "")
            {
                errorProvider1.SetError(tbCity, "Must not be empty");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(tbCity, null);
                e.Cancel = false;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Must not be empty");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbShortcut_Validating(object sender, CancelEventArgs e)
        {

            if (tbShortcut.Text.Length == 3)
            {
                bool letter = true;
                bool upper = true;
                foreach (char c in tbShortcut.Text)
                {
                    if (!Char.IsLetter(c))
                        letter = false;
                    if (!Char.IsUpper(c))
                        upper = false;

                }

                if (upper && letter)
                {
                    errorProvider1.SetError(tbShortcut, null);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(tbShortcut, "Must be 3 uppercase letters");
                    e.Cancel = true;
                }
            }
            else {
                errorProvider1.SetError(tbShortcut, "Must be contain 3 letters");
                e.Cancel = true;
            }
        }

        private void btnSaveAirport_Click(object sender, EventArgs e)
        {
         if (ValidateChildren())
            {
                this.Airport = new Airport(tbCity.Text, tbName.Text, tbShortcut.Text);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
