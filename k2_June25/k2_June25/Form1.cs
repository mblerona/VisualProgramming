using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_June25
{
    public partial class Form1 : Form
    {
        public Scene Scene;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(ClientSize.Width, ClientSize.Height);
            timer1.Start();
            this.DoubleBuffered = true;
            timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (timer1.Interval % 10 == 0)
            //{

                int x = rnd.Next(Ball.Radius, ClientSize.Width-Ball.Radius);  // Random X within the form
                int y = rnd.Next(Ball.Radius,ClientSize.Height - Ball.Radius); // Random Y within the form
                int direction = rnd.Next(2);
                Scene.AddBall(new Ball(new Point(x, y), direction));

            
            Scene.Move();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawAll(e.Graphics);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
