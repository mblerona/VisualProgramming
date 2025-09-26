namespace f1Race
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.lbDrivers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBestLap = new System.Windows.Forms.TextBox();
            this.btnAddLap = new System.Windows.Forms.Button();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.lbLaps = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteDriver);
            this.groupBox1.Controls.Add(this.btnAddDriver);
            this.groupBox1.Controls.Add(this.lbDrivers);
            this.groupBox1.Location = new System.Drawing.Point(89, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 760);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver";
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(19, 679);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(424, 48);
            this.btnDeleteDriver.TabIndex = 4;
            this.btnDeleteDriver.Text = "Delete Driver";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(19, 598);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(424, 48);
            this.btnAddDriver.TabIndex = 3;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // lbDrivers
            // 
            this.lbDrivers.FormattingEnabled = true;
            this.lbDrivers.ItemHeight = 25;
            this.lbDrivers.Location = new System.Drawing.Point(19, 30);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(424, 529);
            this.lbDrivers.TabIndex = 2;
            this.lbDrivers.SelectedIndexChanged += new System.EventHandler(this.lbDrivers_SelectedIndexChanged);
            this.lbDrivers.SelectedValueChanged += new System.EventHandler(this.lbDrivers_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbBestLap);
            this.groupBox2.Controls.Add(this.btnAddLap);
            this.groupBox2.Controls.Add(this.nudMinutes);
            this.groupBox2.Controls.Add(this.nudSeconds);
            this.groupBox2.Controls.Add(this.lbLaps);
            this.groupBox2.Location = new System.Drawing.Point(685, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 760);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laps";
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(23, 650);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(120, 31);
            this.nudTime.TabIndex = 14;
            this.nudTime.ValueChanged += new System.EventHandler(this.nudTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Best Lap";
            // 
            // tbBestLap
            // 
            this.tbBestLap.Enabled = false;
            this.tbBestLap.Location = new System.Drawing.Point(23, 528);
            this.tbBestLap.Name = "tbBestLap";
            this.tbBestLap.Size = new System.Drawing.Size(444, 31);
            this.tbBestLap.TabIndex = 9;
            // 
            // btnAddLap
            // 
            this.btnAddLap.Location = new System.Drawing.Point(316, 380);
            this.btnAddLap.Name = "btnAddLap";
            this.btnAddLap.Size = new System.Drawing.Size(164, 55);
            this.btnAddLap.TabIndex = 8;
            this.btnAddLap.Text = "Add Lap";
            this.btnAddLap.UseVisualStyleBackColor = true;
            this.btnAddLap.Click += new System.EventHandler(this.btnAddLap_Click);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(32, 408);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(120, 31);
            this.nudMinutes.TabIndex = 7;
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudMinutes_ValueChanged);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(185, 408);
            this.nudSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(120, 31);
            this.nudSeconds.TabIndex = 6;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // lbLaps
            // 
            this.lbLaps.FormattingEnabled = true;
            this.lbLaps.ItemHeight = 25;
            this.lbLaps.Location = new System.Drawing.Point(23, 30);
            this.lbLaps.Name = "lbLaps";
            this.lbLaps.Size = new System.Drawing.Size(424, 304);
            this.lbLaps.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 832);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ListBox lbDrivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBestLap;
        private System.Windows.Forms.Button btnAddLap;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.ListBox lbLaps;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

