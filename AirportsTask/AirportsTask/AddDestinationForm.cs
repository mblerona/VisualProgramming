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
    public partial class AddDestinationForm : Form
    {
        public Destination createdDestination {  get; set; }
        public AddDestinationForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createdDestination= new Destination(tbDistanceName.Text, (int) numericUpDown1.Value, (int)numericUpDown2.Value);
            this.DialogResult = DialogResult.OK;
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
