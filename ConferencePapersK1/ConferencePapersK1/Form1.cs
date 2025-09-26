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
    public partial class Form1 : Form
    {

        List<Conference> Conferences;
        int selectedYear;
        Conference SelectedConference;

        

        public Form1()
        {
            InitializeComponent();
            Conferences= new List<Conference>();
            selectedYear = -1;
            SelectedConference = null;
            loadConferences(selectedYear);
            loadYears();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddConference_Click(object sender, EventArgs e)
        {
            NewConference newConference = new NewConference();
            if (newConference.ShowDialog() == DialogResult.OK) {
                Conferences.Add(newConference.Conference);
                loadConferences(selectedYear);
                loadYears();
            }

          

        }

        private void btnRemoveConference_Click(object sender, EventArgs e)
        {
            List<Conference> filtered = new List<Conference>();
            SelectedConference= lbConferences.SelectedItem as Conference;
            foreach (Conference c in Conferences) {
                if (c.ID != SelectedConference.ID) { 
                filtered.Add(c);
                }
            }

            Conferences = filtered;
            loadConferences(selectedYear);
            loadYears();

        }

        private void cbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYear = (int)cbYears.SelectedItem;
            loadConferences(selectedYear);

        }

        private void cbYears_SelectedValueChanged(object sender, EventArgs e)
        {
        
        }

        

        private void lbConferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbConferences.SelectedIndex != -1) { 
            SelectedConference = lbConferences.SelectedItem as Conference;

            }
        }


        private void loadConferences(int year) { 
         lbConferences.Items.Clear();

            foreach(Conference c in Conferences)
            {
                if (year == -1 || c.Year == year) {
                    lbConferences.Items.Add(c);
                }
            }
         
        }

        private void loadYears() {
            cbYears.Items.Clear();
            cbYears.Items.Add(-1);
            foreach (Conference c in Conferences) { 
            if(!cbYears.Items.Contains(c.Year)) {
                cbYears.Items.Add(c.Year);  
                }
            }
        
        }
    }
}
