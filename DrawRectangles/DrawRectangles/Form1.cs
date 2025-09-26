using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawRectangles
{
    public partial class Form1 : Form
    {

        public Scene Scene;
        public Point p1;
        public Point p2;

        int x;
        int y;
        int width;
        int height;
        private Color currentColor;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();    
            this.DoubleBuffered = true;
            this.currentColor = Color.Blue;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (p1.IsEmpty)
                {
                    p1 = e.Location;
                }
                else {
                    Scene.addRectangle(new Point(x, y), width, height, currentColor);
                    p1 = Point.Empty;
                    p2 = Point.Empty;
                }
                Invalidate();
            }


            if(e.Button == MouseButtons.Right) {

                Scene.Select(e.Location);
                Invalidate();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK) { 
            this.currentColor= colorDialog.Color;   
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            p2 = e.Location;
            x = p1.X;
            y = p1.Y;
            if (x > p2.X) x = p2.X;
            if (y > p2.Y) y = p2.Y;
            width = Math.Abs(p1.X - p2.X);
            height = Math.Abs(p1.Y - p2.Y);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawAll(e.Graphics);
            if (!p1.IsEmpty)
            {
                Pen linePen = new Pen(Color.Black, 2);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawRectangle(linePen, x, y, width, height);
                linePen.Dispose();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) { 
            Scene=new Scene();
            
            }
        }
    }
}
