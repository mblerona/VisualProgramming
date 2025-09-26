namespace AirportsTask
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
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.Destinations = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.Destinations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 25;
            this.lbAirports.Location = new System.Drawing.Point(60, 63);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(681, 454);
            this.lbAirports.TabIndex = 0;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            this.lbAirports.SelectedValueChanged += new System.EventHandler(this.lbAirports_SelectedValueChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 25;
            this.lbDestinations.Location = new System.Drawing.Point(1028, 63);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(652, 454);
            this.lbDestinations.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Airports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1023, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destinations";
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(60, 586);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(681, 45);
            this.btnAddAirport.TabIndex = 4;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(60, 679);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(681, 45);
            this.btnDeleteAirport.TabIndex = 5;
            this.btnDeleteAirport.Text = "Delete Airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(60, 770);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(681, 45);
            this.btnAddDestination.TabIndex = 6;
            this.btnAddDestination.Text = "Add Destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // Destinations
            // 
            this.Destinations.Controls.Add(this.label4);
            this.Destinations.Controls.Add(this.label3);
            this.Destinations.Controls.Add(this.tbAverage);
            this.Destinations.Controls.Add(this.tbMostExpensive);
            this.Destinations.Location = new System.Drawing.Point(1028, 586);
            this.Destinations.Name = "Destinations";
            this.Destinations.Size = new System.Drawing.Size(640, 229);
            this.Destinations.TabIndex = 7;
            this.Destinations.TabStop = false;
            this.Destinations.Text = "Destinations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average Distance of Destinations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Most Expensive Destination";
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(26, 173);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(590, 31);
            this.tbAverage.TabIndex = 9;
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Enabled = false;
            this.tbMostExpensive.Location = new System.Drawing.Point(26, 75);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.Size = new System.Drawing.Size(590, 31);
            this.tbMostExpensive.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 950);
            this.Controls.Add(this.Destinations);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Destinations.ResumeLayout(false);
            this.Destinations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.GroupBox Destinations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbMostExpensive;
    }
}

