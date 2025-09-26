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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }
        //private void loadAirports() {
        //    foreach (Airport airport in Airports) { 
        //    lbAirports.Items.Add(airport);
        //    }
        //}
        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddAirportForm addAirportForm = new AddAirportForm();
            if(addAirportForm.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(addAirportForm.Airport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex == -1)
            {
                return;
            }

            DialogResult dg=MessageBox.Show("Sure you want to Delete?", "U sure? ", MessageBoxButtons.OKCancel);
            if(dg==DialogResult.OK)
            {
                int selIndex = lbAirports.SelectedIndex;
                lbAirports.Items.RemoveAt(selIndex);
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1) { 
                AddDestinationForm addDestinationForm = new AddDestinationForm();
                if (addDestinationForm.ShowDialog() == DialogResult.OK) { 
                Airport selectedAirport = lbAirports.SelectedItem as Airport;
                    selectedAirport.Destinations.Add(addDestinationForm.createdDestination);
                    loadDestinations();                
                }
            }
        }


        private void loadDestinations() {
           
            lbDestinations.Items.Clear();
            tbAverage.Clear();
            tbMostExpensive.Clear();

            if (lbAirports.SelectedIndex != -1) {
                Airport selectedAirport = lbAirports.SelectedItem as Airport;
                foreach (Destination destination in selectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                }

                double sum = 0;
                foreach (Destination destination in selectedAirport.Destinations) {
                    sum += destination.Distance;
                
                }
                if(selectedAirport.Destinations.Count >0) {
                    double average = sum / selectedAirport.Destinations.Count;
                    tbAverage.Text = $"{average}";
                }

                if (selectedAirport.Destinations.Count > 0)
                {
                    Destination max = selectedAirport.Destinations[0];
                    for(int i =1; i<selectedAirport.Destinations.Count; i++)
                    {
                        if(selectedAirport.Destinations[i].Price > max.Price) { 
                        max = selectedAirport.Destinations[i];
                        
                        }
                    }

                    tbMostExpensive.Text=max.ToString();    
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
