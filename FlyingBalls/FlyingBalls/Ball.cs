using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    public class Ball
    {
        public Random randomColor= new Random();
        public static int RADIUS { get; } = 20; 
        public Point Center { get; set; }
        //public int coeff { get; set; } = -1;
        public  int colorState { get; set; }

        public Ball(Point Center)
        {
            colorState = randomColor.Next(3);
           this.Center = Center;    
           // this.coeff = coeff;
        }

        public void Draw(Graphics g) {

            Brush b = null;
            if (colorState == 0)
            {
                b = new SolidBrush(Color.Blue);
                g.FillEllipse(b, Center.X-RADIUS, Center.Y-RADIUS, 2*RADIUS,2*RADIUS);
            }
            else if (colorState == 1)
            {
                b = new SolidBrush(Color.Red);
                g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            }
            else {
                b = new SolidBrush(Color.Green);
                g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            }
            b.Dispose();
            

        }


        public void Move() { 
        
            Center= new Point(Center.X+3, Center.Y);
        }


        public bool isHit(Point point)
        {

            return Math.Sqrt(Math.Pow(Center.X-point.X,2)+Math.Pow(Center.Y- point.Y,2))<=RADIUS;
        }
    }
}
