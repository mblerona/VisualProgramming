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
    public partial class LineForm : Form
    {

        public BusLine Line;
        public LineForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Line = new BusLine(tbDestination.Text,(int)nudHour.Value,(int)nudMinute.Value, (int)nudPrice.Value);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
        }
    }
}
