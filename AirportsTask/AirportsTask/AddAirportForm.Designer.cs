namespace AirportsTask
{
    partial class AddAirportForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAirport = new System.Windows.Forms.Button();
            this.tbShortcut = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epAirport = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAirport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSaveAirport);
            this.groupBox1.Controls.Add(this.tbShortcut);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Airport";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(276, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAirport
            // 
            this.btnSaveAirport.Location = new System.Drawing.Point(45, 435);
            this.btnSaveAirport.Name = "btnSaveAirport";
            this.btnSaveAirport.Size = new System.Drawing.Size(276, 39);
            this.btnSaveAirport.TabIndex = 6;
            this.btnSaveAirport.Text = "Save";
            this.btnSaveAirport.UseVisualStyleBackColor = true;
            this.btnSaveAirport.Click += new System.EventHandler(this.btnSaveAirport_Click);
            // 
            // tbShortcut
            // 
            this.tbShortcut.Location = new System.Drawing.Point(45, 335);
            this.tbShortcut.Name = "tbShortcut";
            this.tbShortcut.Size = new System.Drawing.Size(630, 31);
            this.tbShortcut.TabIndex = 5;
            this.tbShortcut.Validating += new System.ComponentModel.CancelEventHandler(this.tbShortcut_Validating);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(45, 226);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(630, 31);
            this.tbName.TabIndex = 4;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(45, 117);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(630, 31);
            this.tbCity.TabIndex = 3;
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbCity_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shortcut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // epAirport
            // 
            this.epAirport.ContainerControl = this;
            // 
            // AddAirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 601);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAirportForm";
            this.Text = "AddAirportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAirport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbShortcut;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAirport;
        private System.Windows.Forms.ErrorProvider epAirport;
    }
}