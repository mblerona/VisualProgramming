using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawForms
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }

        public string shapeType { get; set; } = "Circle";
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Scene.addShape(new Circle(Color.Red, 30, e.Location));
            Scene.Click(e.Location, shapeType);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawAll(e.Graphics);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.Pulse();
            Invalidate();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeType = "Square";
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeType = "Circle";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
