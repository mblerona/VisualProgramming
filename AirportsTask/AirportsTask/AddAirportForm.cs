using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportsTask
{
    public partial class AddAirportForm : Form
    {
        public Airport Airport { get; set; }
        public AddAirportForm()
        {
            InitializeComponent();
        }

        private void btnSaveAirport_Click(object sender, EventArgs e)
        {
            this.Airport= new Airport(tbShortcut.Text, tbName.Text, tbCity.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text == "")
            {
                epAirport.SetError(tbCity, "Must add value");
            }
            else {
                epAirport.SetError(tbCity, null);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                epAirport.SetError(tbName, "Must add value");
            }
            else
            {
                epAirport.SetError(tbName, null);
            }
        }

        private void tbShortcut_Validating(object sender, CancelEventArgs e)
        {
            if (tbShortcut.Text.Length == 3) {
                bool upper = true;
                foreach (char c in tbShortcut.Text)
                {
                    if (Char.IsLower(c) || !Char.IsLetter(c))
                    {
                        upper = false;
                        break;
                    }
                }

                if (upper) {
                    epAirport.SetError(tbShortcut, null);
                }
                else
                {
                    epAirport.SetError(tbShortcut, "Not valid");
                }

            }
            else
            {
                epAirport.SetError(tbShortcut, "Must be 3 characters");
            }
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
