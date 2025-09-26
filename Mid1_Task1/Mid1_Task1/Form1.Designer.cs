namespace Mid1_Task1
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
            this.lbBuses = new System.Windows.Forms.ListBox();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.btnAddBuss = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBuses
            // 
            this.lbBuses.FormattingEnabled = true;
            this.lbBuses.ItemHeight = 25;
            this.lbBuses.Location = new System.Drawing.Point(92, 80);
            this.lbBuses.Name = "lbBuses";
            this.lbBuses.Size = new System.Drawing.Size(480, 504);
            this.lbBuses.TabIndex = 0;
            this.lbBuses.SelectedIndexChanged += new System.EventHandler(this.lbBuses_SelectedIndexChanged);
            this.lbBuses.SelectedValueChanged += new System.EventHandler(this.lbBuses_SelectedValueChanged);
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.ItemHeight = 25;
            this.lbLines.Location = new System.Drawing.Point(789, 80);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(533, 504);
            this.lbLines.TabIndex = 1;
            this.lbLines.SelectedIndexChanged += new System.EventHandler(this.lbLines_SelectedIndexChanged);
            this.lbLines.SelectedValueChanged += new System.EventHandler(this.lbLines_SelectedValueChanged);
            // 
            // btnAddBuss
            // 
            this.btnAddBuss.Location = new System.Drawing.Point(92, 624);
            this.btnAddBuss.Name = "btnAddBuss";
            this.btnAddBuss.Size = new System.Drawing.Size(480, 49);
            this.btnAddBuss.TabIndex = 2;
            this.btnAddBuss.Text = "Add Bus";
            this.btnAddBuss.UseVisualStyleBackColor = true;
            this.btnAddBuss.Click += new System.EventHandler(this.btnAddBuss_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Location = new System.Drawing.Point(92, 713);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(480, 49);
            this.btnDeleteBus.TabIndex = 3;
            this.btnDeleteBus.Text = "Delete Buss";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(92, 794);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(480, 49);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Add Bus Line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAverage);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Location = new System.Drawing.Point(789, 624);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "line";
            // 
            // tbMax
            // 
            this.tbMax.Enabled = false;
            this.tbMax.Location = new System.Drawing.Point(3, 65);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(477, 31);
            this.tbMax.TabIndex = 0;
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(3, 149);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(477, 31);
            this.tbAverage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Most expensive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average Price of lines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Busees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lines";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 873);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBuss);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbBuses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBuses;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Button btnAddBuss;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

