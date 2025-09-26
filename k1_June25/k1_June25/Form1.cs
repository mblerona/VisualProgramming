using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_June25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            lbNotes.Items.Add(new Note(tbtitle.Text, tbContent.Text, cbType.Text));
            tbContent.Clear();
            tbtitle.Clear();
            cbType.SelectedIndex = -1;
            countNotes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateContent() {
            tbDescription.Clear();
            if (lbNotes.SelectedIndex != -1) {
               Note note = lbNotes.SelectedItem as Note;
               tbDescription.Text= note.Description;
            }
        }

        private void lbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateContent();
        }

        private void lbNotes_SelectedValueChanged(object sender, EventArgs e)
        {
            updateContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1) {
                DialogResult dg = MessageBox.Show("Are you sure?", "Delete note", MessageBoxButtons.YesNo);

                if(dg == DialogResult.Yes)
                {
                    lbNotes.Items.RemoveAt(lbNotes.SelectedIndex);
                }
                countNotes();
            }
        }

        private void countNotes() {
            Dictionary<string, int> countTypes = new Dictionary<string, int>();
            foreach (Note note in lbNotes.Items) { 
            if(!countTypes.ContainsKey(note.Type))
                {
                    countTypes[note.Type] = 0;

                }
                countTypes[note.Type]++;
            }


            StringBuilder sb = new StringBuilder();
            foreach(var  type in countTypes) {
                sb.AppendLine($"{type.Key}: {type.Value} ");
            }

            tbCounter.Text = sb.ToString(); 
        
        }


       
    }
}
