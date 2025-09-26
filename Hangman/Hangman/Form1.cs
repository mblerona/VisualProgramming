using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public RandomPicker randomPicker;
        public HangmanWord hangmanWord;
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
            randomPicker = new RandomPicker();

            this.Init();
        }

        private void Init() {

            hangmanWord = new HangmanWord(randomPicker.Pick());
            tbTimer.Text = "02:00";
            updateTextBoxes();
            pbWrongTries.Maximum = HangmanWord.MAX_RETRIES;
            pbWrongTries.Value = 0;

            timeLeft = 120;
            timer1.Start();

            pbTimer.Maximum = 120;
            pbTimer.Value = 120;
            
        }

        private void updateTextBoxes() {
            tbWordState.Text = hangmanWord.GetMaskedWord();
            tbGuessedLetters.Text = hangmanWord.GetMaskedGuessedLettters();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLetter.Text)) {
                char letter = tbLetter.Text[0];
                hangmanWord.GuessLetter(letter);
                updateTextBoxes();
                pbWrongTries.Value = hangmanWord.WrongCount;
                if (hangmanWord.Win())
                {
                    showMessageBoxes("Congrats you won.  New Game?");
                }
                else if (hangmanWord.Lose()) {
                    showMessageBoxes("Sorry you lost. New Game?");
                }
                
            
            }

            tbLetter.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            tbTimer.Text = String.Format("{0}:{1}", timeLeft/60, timeLeft%60);

            pbTimer.Value = timeLeft;

            if (timeLeft == 0)
            {

                showMessageBoxes("Time is up");
            }
        }

        private void showMessageBoxes(string Message) {
            DialogResult dg = MessageBox.Show(Message, "Game over", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                this.Init();
            }
            else
            {
                this.Close();
            }

        }
    }
}
