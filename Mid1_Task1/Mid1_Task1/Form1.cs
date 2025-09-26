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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAddBuss_Click(object sender, EventArgs e)
        {
            BusForm busform = new BusForm();
            if (busform.ShowDialog() == DialogResult.OK) {
                lbBuses.Items.Add(busform.Bus);
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (lbBuses.SelectedIndex != -1) {
                DialogResult dg = MessageBox.Show("Delete bus?","Delete bus??", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {

                    lbBuses.Items.RemoveAt(lbBuses.SelectedIndex);
                    lbLines.Items.Clear();
                }
                else {
                    dg= DialogResult.Cancel;
                }
               
            
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (lbBuses.SelectedIndex != -1) {
               
                LineForm lineForm = new LineForm();
                if (lineForm.ShowDialog() == DialogResult.OK)
                {
                    Bus selectedBus = lbBuses.SelectedItem as Bus;
                    selectedBus.BusLines.Add(lineForm.Line);
                    LoadDestination();
                }
               
            }

        }


        private void LoadDestination()
        {
            lbLines.Items.Clear();
            tbAverage.Clear();
            tbMax.Clear();
            
            if (lbBuses.SelectedIndex != -1)
            {
              
                Bus selectedBus = lbBuses.SelectedItem as Bus;
                double sum = 0;
                foreach (BusLine busLine in selectedBus.BusLines)
                {
                    
                    lbLines.Items.Add(busLine);
                     sum += (double)busLine.Price;

                }

                if (lbLines.Items.Count > 0) { 
                double average = sum/ lbLines.Items.Count;
                    BusLine max = selectedBus.BusLines[0] as BusLine;

                    for(int i =0;i < selectedBus.BusLines.Count;i++)
                    {
                        if (selectedBus.BusLines[i].Price > max.Price) {
                            max = selectedBus.BusLines[i];

                        }
                    }

                    tbAverage.Text = $"{average}";
                    tbMax.Text = max.ToString();
                }

            }
        }

        private void lbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbLines_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDestination();
        }

        private void lbBuses_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDestination();
        }
    }
}
