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
    public partial class DestinationForm : Form
    {
        public Destination Destination { get; set; }

        public DestinationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSaveDestination_Click(object sender, EventArgs e)
        {
            Destination = new Destination(tbName.Text,(int) nudDistance.Value,(int) nudPrice.Value);
            this.DialogResult = DialogResult.OK;


        }
    }
}
