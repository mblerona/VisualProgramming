using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            DialogResult result = teamForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                lbTeams.Items.Add(teamForm.CreatedTeam);
            }
        }

        private void btnAddBilten_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItems.Count == 2)
            {
                Team team1 = lbTeams.SelectedItems[0] as Team;
                Team team2 = lbTeams.SelectedItems[1] as Team;

                if (team1.Country != team2.Country)
                {
                    MessageBox.Show("Teams must be of same country");
                }
                else {
                    Game game = new Game(mtbAddShifra.Text, team1, team2, numericUpDown1.Value, numericUpDownX.Value, numericUpDown2.Value);
                    lbBilten.Items.Add(game);
                    lbTeams.ClearSelected();
                    numericUpDown1.Value = 1.0M;
                    numericUpDownX.Value = 1.0M;
                    numericUpDown2.Value = 1.0M;

                    mtbAddShifra.Clear();
                }
            }
            else {
                MessageBox.Show("You must select 2 teams");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbBilten.SelectedItems.Clear();

            String codeToSearch = tbShifra.Text;
            for(int i =0; i<lbBilten.Items.Count; i++)
            {
                Game game = lbBilten.Items[i] as Game;
                if (game.Code == codeToSearch) { 
                lbBilten.SelectedIndex = i;
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbBilten.SelectedIndex != -1 && cbTip.SelectedIndex!=-1) { 
                Game game = lbBilten.SelectedItem as Game;
                int type = cbTip.Text =="1"? 0 : (cbTip.Text=="2" ? 1 : 2);
                GameForTicket gameForTicket = new GameForTicket(game, type);

                lbTicket.Items.Add(gameForTicket);
                lbBilten.ClearSelected();
                tbShifra.Clear();
                tbTotalCoeff.Text = recalculateCoeff().ToString();
                tbWinning.Text =String.Format("{0}", recalculateCoeff() * nudPayment.Value);
                
            }
        }

        private void cbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTeams.Items.Add(new Team("Barcelona", "Spain"));
            lbTeams.Items.Add(new Team("RMA", "Spain"));
            lbTeams.Items.Add(new Team("Milan", "Italy"));
            lbTeams.Items.Add(new Team("Liverpool", "UK"));
            lbTeams.Items.Add(new Team("Juventus", "Italy"));
        }



        private decimal recalculateCoeff() {
            decimal product = 1;
            for(int i =0; i<lbTicket.Items.Count;i++)  { 
                GameForTicket gameForTicket = lbTicket.Items[i] as GameForTicket;

                int tip=gameForTicket.Tip;
                Game game = gameForTicket.Game;
                product *= (tip == 0 ? game.coeff1 : tip == 1 ? game.coeffX : game.coeff2);
            }
            return product;
        }

        private void lbTicket_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            tbWinning.Text = String.Format("{0}", recalculateCoeff() * nudPayment.Value);
        }
    }
}
