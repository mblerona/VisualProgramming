namespace test1
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
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbBilten = new System.Windows.Forms.ListBox();
            this.lbTicket = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddBilten = new System.Windows.Forms.Button();
            this.mtbAddShifra = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbShifra = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWinning = new System.Windows.Forms.TextBox();
            this.nudPayment = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalCoeff = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 25;
            this.lbTeams.Location = new System.Drawing.Point(40, 58);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTeams.Size = new System.Drawing.Size(425, 454);
            this.lbTeams.TabIndex = 0;
            // 
            // lbBilten
            // 
            this.lbBilten.FormattingEnabled = true;
            this.lbBilten.ItemHeight = 25;
            this.lbBilten.Location = new System.Drawing.Point(519, 58);
            this.lbBilten.Name = "lbBilten";
            this.lbBilten.Size = new System.Drawing.Size(419, 454);
            this.lbBilten.TabIndex = 1;
            // 
            // lbTicket
            // 
            this.lbTicket.FormattingEnabled = true;
            this.lbTicket.ItemHeight = 25;
            this.lbTicket.Location = new System.Drawing.Point(995, 58);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(418, 454);
            this.lbTicket.TabIndex = 2;
            this.lbTicket.SizeChanged += new System.EventHandler(this.lbTicket_SizeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDownX);
            this.groupBox1.Controls.Add(this.btnAddTeam);
            this.groupBox1.Controls.Add(this.btnAddBilten);
            this.groupBox1.Controls.Add(this.mtbAddShifra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 505);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Bilten";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(91, 232);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(280, 31);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Tag = "";
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 2;
            this.numericUpDownX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownX.Location = new System.Drawing.Point(91, 175);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(280, 31);
            this.numericUpDownX.TabIndex = 14;
            this.numericUpDownX.Tag = "";
            this.numericUpDownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(26, 423);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(345, 44);
            this.btnAddTeam.TabIndex = 13;
            this.btnAddTeam.Text = "Add New Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddBilten
            // 
            this.btnAddBilten.Location = new System.Drawing.Point(26, 373);
            this.btnAddBilten.Name = "btnAddBilten";
            this.btnAddBilten.Size = new System.Drawing.Size(345, 44);
            this.btnAddBilten.TabIndex = 12;
            this.btnAddBilten.Text = "Add to Bilten";
            this.btnAddBilten.UseVisualStyleBackColor = true;
            this.btnAddBilten.Click += new System.EventHandler(this.btnAddBilten_Click);
            // 
            // mtbAddShifra
            // 
            this.mtbAddShifra.Location = new System.Drawing.Point(109, 293);
            this.mtbAddShifra.Mask = "999";
            this.mtbAddShifra.Name = "mtbAddShifra";
            this.mtbAddShifra.Size = new System.Drawing.Size(215, 31);
            this.mtbAddShifra.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shifra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(91, 117);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(280, 31);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Set coefficients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose 2 teams of same state";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTip);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbShifra);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(519, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 505);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Match to Ticket";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbShifra
            // 
            this.tbShifra.Location = new System.Drawing.Point(104, 120);
            this.tbShifra.Name = "tbShifra";
            this.tbShifra.Size = new System.Drawing.Size(216, 31);
            this.tbShifra.TabIndex = 14;
            this.tbShifra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(345, 44);
            this.button3.TabIndex = 13;
            this.button3.Text = "Add Match";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Shifra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(266, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Select Match or add Shifra";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbWinning);
            this.groupBox3.Controls.Add(this.nudPayment);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbTotalCoeff);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(995, 545);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 505);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pay Ticket";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Winning";
            // 
            // tbWinning
            // 
            this.tbWinning.Enabled = false;
            this.tbWinning.Location = new System.Drawing.Point(26, 331);
            this.tbWinning.Name = "tbWinning";
            this.tbWinning.Size = new System.Drawing.Size(294, 31);
            this.tbWinning.TabIndex = 17;
            // 
            // nudPayment
            // 
            this.nudPayment.Location = new System.Drawing.Point(26, 232);
            this.nudPayment.Name = "nudPayment";
            this.nudPayment.Size = new System.Drawing.Size(294, 31);
            this.nudPayment.TabIndex = 16;
            this.nudPayment.ValueChanged += new System.EventHandler(this.nudPayment_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Payment";
            // 
            // tbTotalCoeff
            // 
            this.tbTotalCoeff.Location = new System.Drawing.Point(21, 120);
            this.tbTotalCoeff.Name = "tbTotalCoeff";
            this.tbTotalCoeff.Size = new System.Drawing.Size(299, 31);
            this.tbTotalCoeff.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(26, 423);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(345, 44);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total Coefficient";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tip";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cbTip.Location = new System.Drawing.Point(104, 212);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(216, 33);
            this.cbTip.TabIndex = 16;
            this.cbTip.SelectedIndexChanged += new System.EventHandler(this.cbTip_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 1108);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.lbBilten);
            this.Controls.Add(this.lbTeams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbBilten;
        private System.Windows.Forms.ListBox lbTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddBilten;
        private System.Windows.Forms.MaskedTextBox mtbAddShifra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbShifra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalCoeff;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWinning;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label11;
    }
}

