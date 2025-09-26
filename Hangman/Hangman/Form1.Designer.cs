namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.tbWordState = new System.Windows.Forms.TextBox();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuessedLetters = new System.Windows.Forms.TextBox();
            this.pbWrongTries = new System.Windows.Forms.ProgressBar();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbTimer
            // 
            this.tbTimer.Enabled = false;
            this.tbTimer.Location = new System.Drawing.Point(936, 74);
            this.tbTimer.Multiline = true;
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(110, 71);
            this.tbTimer.TabIndex = 0;
            // 
            // tbWordState
            // 
            this.tbWordState.Enabled = false;
            this.tbWordState.Location = new System.Drawing.Point(59, 128);
            this.tbWordState.Multiline = true;
            this.tbWordState.Name = "tbWordState";
            this.tbWordState.Size = new System.Drawing.Size(701, 63);
            this.tbWordState.TabIndex = 1;
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(89, 247);
            this.tbLetter.Multiline = true;
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(110, 68);
            this.tbLetter.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 47);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pogodeni bukvi";
            // 
            // tbGuessedLetters
            // 
            this.tbGuessedLetters.Enabled = false;
            this.tbGuessedLetters.Location = new System.Drawing.Point(59, 441);
            this.tbGuessedLetters.Multiline = true;
            this.tbGuessedLetters.Name = "tbGuessedLetters";
            this.tbGuessedLetters.Size = new System.Drawing.Size(701, 52);
            this.tbGuessedLetters.TabIndex = 5;
            // 
            // pbWrongTries
            // 
            this.pbWrongTries.Location = new System.Drawing.Point(59, 527);
            this.pbWrongTries.Name = "pbWrongTries";
            this.pbWrongTries.Size = new System.Drawing.Size(940, 41);
            this.pbWrongTries.TabIndex = 6;
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(59, 594);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(940, 35);
            this.pbTimer.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 683);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.pbWrongTries);
            this.Controls.Add(this.tbGuessedLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.tbWordState);
            this.Controls.Add(this.tbTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.TextBox tbWordState;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGuessedLetters;
        private System.Windows.Forms.ProgressBar pbWrongTries;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

