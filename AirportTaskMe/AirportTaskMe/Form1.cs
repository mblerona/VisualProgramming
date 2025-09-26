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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AirportForm airportForm = new AirportForm();
            airportForm.ShowDialog();
            lbAirports.Items.Add(airportForm.Airport);
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1) {
                DialogResult dg = MessageBox.Show("You sure you want to delete this ? ", "???", MessageBoxButtons.OKCancel);

                if (dg == DialogResult.OK)
                {
                    lbAirports.Items.RemoveAt(lbAirports.SelectedIndex);
                }

            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                 DestinationForm addDestinationForm = new DestinationForm();
                if (addDestinationForm.ShowDialog() == DialogResult.OK)
                {
                    Airport selectedAirport = lbAirports.SelectedItem as Airport;
                    selectedAirport.Destinations.Add(addDestinationForm.Destination);
                    loadDestinations();
                }
            }
        }


        public void loadDestinations() { 
            lbDestinations.Items.Clear();
            tbAverage.Clear();
            tbMostExpensive.Clear();

            if(lbAirports.SelectedIndex != -1)
            {
                Airport selectedAirport = lbAirports.SelectedItem as Airport;
                double sum = 0;
                foreach(Destination destination in selectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                    sum += destination.Distance;
                }


                if (selectedAirport.Destinations.Count > 0) {
                    tbAverage.Text = (sum / lbDestinations.Items.Count).ToString();
                    Destination max = selectedAirport.Destinations[0];
                    for(int i =0; i <selectedAirport.Destinations.Count; i++)
                    {
                        if (selectedAirport.Destinations[i].Distance> max.Distance)
                        {
                            max= selectedAirport.Destinations[i];
                        }
                    }
                    tbMostExpensive.Text = max.ToString();
                }

            }




        
        
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }

        private void lbAirports_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }
    }
}
