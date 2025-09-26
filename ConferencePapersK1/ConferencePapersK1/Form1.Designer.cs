namespace ConferencePapersK1
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
            this.lbConferences = new System.Windows.Forms.ListBox();
            this.cbYears = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddConference = new System.Windows.Forms.Button();
            this.btnRemoveConference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConferences
            // 
            this.lbConferences.FormattingEnabled = true;
            this.lbConferences.ItemHeight = 25;
            this.lbConferences.Location = new System.Drawing.Point(95, 25);
            this.lbConferences.Name = "lbConferences";
            this.lbConferences.Size = new System.Drawing.Size(444, 554);
            this.lbConferences.TabIndex = 0;
            this.lbConferences.SelectedIndexChanged += new System.EventHandler(this.lbConferences_SelectedIndexChanged);
            // 
            // cbYears
            // 
            this.cbYears.FormattingEnabled = true;
            this.cbYears.Items.AddRange(new object[] {
            "-1"});
            this.cbYears.Location = new System.Drawing.Point(240, 612);
            this.cbYears.Name = "cbYears";
            this.cbYears.Size = new System.Drawing.Size(299, 33);
            this.cbYears.TabIndex = 1;
            this.cbYears.SelectedIndexChanged += new System.EventHandler(this.cbYears_SelectedIndexChanged);
            this.cbYears.SelectedValueChanged += new System.EventHandler(this.cbYears_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Godina";
            // 
            // btnAddConference
            // 
            this.btnAddConference.Location = new System.Drawing.Point(118, 669);
            this.btnAddConference.Name = "btnAddConference";
            this.btnAddConference.Size = new System.Drawing.Size(421, 41);
            this.btnAddConference.TabIndex = 3;
            this.btnAddConference.Text = "Add Conference";
            this.btnAddConference.UseVisualStyleBackColor = true;
            this.btnAddConference.Click += new System.EventHandler(this.btnAddConference_Click);
            // 
            // btnRemoveConference
            // 
            this.btnRemoveConference.Location = new System.Drawing.Point(118, 728);
            this.btnRemoveConference.Name = "btnRemoveConference";
            this.btnRemoveConference.Size = new System.Drawing.Size(421, 41);
            this.btnRemoveConference.TabIndex = 4;
            this.btnRemoveConference.Text = "Remove Conference";
            this.btnRemoveConference.UseVisualStyleBackColor = true;
            this.btnRemoveConference.Click += new System.EventHandler(this.btnRemoveConference_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 808);
            this.Controls.Add(this.btnRemoveConference);
            this.Controls.Add(this.btnAddConference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYears);
            this.Controls.Add(this.lbConferences);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbConferences;
        private System.Windows.Forms.ComboBox cbYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddConference;
        private System.Windows.Forms.Button btnRemoveConference;
    }
}

