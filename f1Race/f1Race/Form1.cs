using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f1Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nudMinutes.Minimum = -1;
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            NewDriverForm newDriverForm = new NewDriverForm();
            if (newDriverForm.ShowDialog() == DialogResult.OK) { 
            lbDrivers.Items.Add(newDriverForm.Driver);

            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1) {
                if (MessageBox.Show("Are you sure?", "SUREEE", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    lbDrivers.Items.RemoveAt(lbDrivers.SelectedIndex);
                    lbLaps.Items.Clear();

                }
          
            }
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            if(lbDrivers.SelectedIndex != -1) { 
            Driver selectedDriver = lbDrivers.SelectedItem as Driver;
                selectedDriver.Laps.Add(new Lap((int)nudSeconds.Value, (int)nudMinutes.Value));
                loadLaps();
           
             
            }
        }
      

        private void loadLaps() {
            lbLaps.Items.Clear();
            nudMinutes.Value = 0; nudSeconds.Value = 0; tbBestLap.Clear();
            nudTime.Value = 0;
            if (lbDrivers.SelectedIndex != -1)
            {
               
                Driver selectedDriver = lbDrivers.SelectedItem as Driver;
               
                foreach (Lap lap in selectedDriver.Laps)
                {
                    if(lap.convertTime(lap.minutes, lap.seconds) > nudTime.Value)
                    
                    lbLaps.Items.Add(lap);

                  
                }

                if (lbLaps.Items.Count > 0) {
                    Lap max = selectedDriver.Laps[0] as Lap;
                    for(int i = 0; i < selectedDriver.Laps.Count; i++)
                    {

                        if (max.convertTime(max.minutes, max.seconds) >selectedDriver.Laps[i].convertTime(selectedDriver.Laps[i].minutes, selectedDriver.Laps[i].seconds)) { 
                        max = selectedDriver.Laps[i];   
                        }
                    }

                    tbBestLap.Text=max.ToString();
                }
            }
           
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLaps() ;
        }

        private void lbDrivers_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLaps();
        }

        private void nudTime_ValueChanged(object sender, EventArgs e)
        {
            loadLaps();
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinutes.Value == 0)
            {
                nudSeconds.Minimum = 0;
            }
            else {
                nudSeconds.Minimum =-1;
            }



            if (nudSeconds.Value == 60)
            {
                nudSeconds.Value = 0;
                nudMinutes.Value += 1;
            }



            if (nudSeconds.Value == -1) {
                if (nudMinutes.Value > 0)
                {
                    nudSeconds.Value = 59;
                    nudMinutes.Value -= 1;
                }
               
             
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
