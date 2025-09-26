namespace AirportTaskMe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aerodromi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destinacii";
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 25;
            this.lbAirports.Location = new System.Drawing.Point(26, 74);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(593, 529);
            this.lbAirports.TabIndex = 2;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            this.lbAirports.SelectedValueChanged += new System.EventHandler(this.lbAirports_SelectedValueChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 25;
            this.lbDestinations.Location = new System.Drawing.Point(669, 74);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(550, 529);
            this.lbDestinations.TabIndex = 3;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(26, 651);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(593, 50);
            this.btnAddAirport.TabIndex = 4;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(26, 717);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(593, 46);
            this.btnDeleteAirport.TabIndex = 5;
            this.btnDeleteAirport.Text = "Delete Airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(26, 785);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(593, 46);
            this.btnAddDestination.TabIndex = 6;
            this.btnAddDestination.Text = "Add Destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAverage);
            this.groupBox1.Controls.Add(this.tbMostExpensive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(669, 626);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 219);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinations";
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(20, 159);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(511, 31);
            this.tbAverage.TabIndex = 3;
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Enabled = false;
            this.tbMostExpensive.Location = new System.Drawing.Point(20, 78);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.Size = new System.Drawing.Size(511, 31);
            this.tbMostExpensive.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Average Distances";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "most Expensive Destination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 888);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAverage;
    }
}

