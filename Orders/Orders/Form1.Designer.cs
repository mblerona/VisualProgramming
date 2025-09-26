namespace Orders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.btnSmetka = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeNowLabel = new System.Windows.Forms.Label();
            this.lbSmetki = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSmetka);
            this.groupBox1.Controls.Add(this.lbOrders);
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 803);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "naracaj";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbSmetki);
            this.groupBox2.Controls.Add(this.timeNowLabel);
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Location = new System.Drawing.Point(707, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 823);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "smetki";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(23, 48);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(520, 46);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Vnesi Naracka";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 25;
            this.lbOrders.Location = new System.Drawing.Point(23, 108);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(520, 579);
            this.lbOrders.TabIndex = 1;
            // 
            // btnSmetka
            // 
            this.btnSmetka.Location = new System.Drawing.Point(23, 722);
            this.btnSmetka.Name = "btnSmetka";
            this.btnSmetka.Size = new System.Drawing.Size(520, 50);
            this.btnSmetka.TabIndex = 2;
            this.btnSmetka.Text = "Smetka";
            this.btnSmetka.UseVisualStyleBackColor = true;
            this.btnSmetka.Click += new System.EventHandler(this.btnSmetka_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(32, 68);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(65, 25);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time:";
            // 
            // timeNowLabel
            // 
            this.timeNowLabel.AutoSize = true;
            this.timeNowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNowLabel.Location = new System.Drawing.Point(147, 27);
            this.timeNowLabel.Name = "timeNowLabel";
            this.timeNowLabel.Size = new System.Drawing.Size(124, 42);
            this.timeNowLabel.TabIndex = 4;
            this.timeNowLabel.Text = "label2";
            this.timeNowLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.timeNowLabel_Paint);
            // 
            // lbSmetki
            // 
            this.lbSmetki.FormattingEnabled = true;
            this.lbSmetki.ItemHeight = 25;
            this.lbSmetki.Location = new System.Drawing.Point(37, 128);
            this.lbSmetki.Name = "lbSmetki";
            this.lbSmetki.Size = new System.Drawing.Size(448, 579);
            this.lbSmetki.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 748);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vkupno";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(173, 745);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(312, 31);
            this.tbTotal.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 847);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnSmetka;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSmetki;
        private System.Windows.Forms.Label timeNowLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

