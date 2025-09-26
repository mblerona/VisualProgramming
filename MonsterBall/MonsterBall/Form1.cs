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

namespace MonsterBall
{
    public partial class Form1 : Form
    {

        public Scene Scene;
        public Color Color;
        int left;
        int top;
        int width;
        int height;

        public Form1()
        {
            InitializeComponent();

            Scene = new Scene();
            Color = Color.Purple;
            this.DoubleBuffered = true;
            timer1.Start();
            timer1.Interval = 50;
            this.left = 20;
            this.top = 60;
            width = this.Width - (3 * left);
            height = this.Height - (int)(2.5 * top);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Pen p = new Pen(Color.Black, 3); 
            Graphics g = e.Graphics;
            g.DrawRectangle(p, left, top, width, height);
            p.Dispose();
            Scene.DrawAll(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.MoveBalls(top, left, width, height);
            Scene.checkCollisions();
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - (3 * left);
            height = this.Height - (int)(2.5 * top);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.AddBall(new Ball(e.Location));
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) { 
           this.Color = cd.Color;
            }
        }


        private void SaveScene(String Path) {
            FileStream fs = new FileStream(Path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Scene);
            fs.Close();

        }

        private void OpenScene(String Path) {
            FileStream fs = new FileStream(Path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Scene = formatter.Deserialize(fs) as Scene;
            fs.Close();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
            else {
                this.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        SaveFileDialog openFileDialog = new SaveFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               SaveScene(openFileDialog.FileName);
            }
            else
            {
                this.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene();
            Invalidate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("# Balls: {0}", Scene.Balls.Count);
        }
    }
}
