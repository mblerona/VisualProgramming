using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    public partial class Form1 : Form
    {
        BallsDoc ballsDoc;
        Color currentColor;
        
        int leftX;
        int topY;
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
            ballsDoc = new BallsDoc();
            currentColor = Color.Red;
            this.DoubleBuffered = true;
  
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
            leftX = 20;
            topY = 60;
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
            ballsDoc.GenerateHoles(leftX, topY, width, height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void timer_Tick(object sender, EventArgs e)
        {
           
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd= new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK) { 
            currentColor = cd.Color;
            }
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballsDoc.GenerateHoles(leftX, topY, width, height);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //toolStripStatusLabel1.Text = string.Format("# Balls: {0}", ballsDoc.Balls.Count);
        }
        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("# Balls: {0}", ballsDoc.Balls.Count);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, leftX, topY, width, height);
            pen.Dispose();
            ballsDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            ballsDoc.AddBall(new Ball(e.Location, currentColor));
            Invalidate(true);
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballsDoc.MoveBalls(leftX, topY, width, height);
            ballsDoc.CheckColisions();
            Invalidate(true);
        }


        private void saveScene(string path) {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(f, ballsDoc);
            f.Close();
        
        }


        private void openScene(string path) {
            FileStream f = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            ballsDoc = formatter.Deserialize(f) as BallsDoc;
            f.Close() ;
        
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballsDoc=new BallsDoc();
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                openScene(dlg.FileName);
            }
            else {

                this.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                saveScene(dlg.FileName);
            }
            else {
                this.Close();
                    }
        }
    }
}
