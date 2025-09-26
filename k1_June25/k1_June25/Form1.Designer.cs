namespace k1_June25
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
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbCounter = new System.Windows.Forms.TextBox();
            this.tbtitle = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNotes
            // 
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.ItemHeight = 25;
            this.lbNotes.Location = new System.Drawing.Point(553, 132);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(393, 479);
            this.lbNotes.TabIndex = 0;
            this.lbNotes.SelectedIndexChanged += new System.EventHandler(this.lbNotes_SelectedIndexChanged);
            this.lbNotes.SelectedValueChanged += new System.EventHandler(this.lbNotes_SelectedValueChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(553, 662);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(393, 172);
            this.tbDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note Content";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(553, 878);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(393, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Note";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbCounter
            // 
            this.tbCounter.Location = new System.Drawing.Point(59, 769);
            this.tbCounter.Multiline = true;
            this.tbCounter.Name = "tbCounter";
            this.tbCounter.Size = new System.Drawing.Size(393, 151);
            this.tbCounter.TabIndex = 4;
            this.tbCounter.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbtitle
            // 
            this.tbtitle.Location = new System.Drawing.Point(78, 202);
            this.tbtitle.Name = "tbtitle";
            this.tbtitle.Size = new System.Drawing.Size(374, 31);
            this.tbtitle.TabIndex = 5;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(78, 351);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(374, 92);
            this.tbContent.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Study",
            "Work",
            "Other"});
            this.cbType.Location = new System.Drawing.Point(78, 521);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(374, 33);
            this.cbType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(78, 621);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(374, 82);
            this.btnAddNote.TabIndex = 11;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Note List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 961);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbtitle);
            this.Controls.Add(this.tbCounter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbNotes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotes;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbCounter;
        private System.Windows.Forms.TextBox tbtitle;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label label5;
    }
}

