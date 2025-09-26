using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    [Serializable]
    public class Ball
    {

        public Point Center { get; set; }
        public  int Radius  {get; set; }
        public Color Color { get; set; }
        public double Velocity { get; set; } = 10;
        public double Angle { get; set; }
        public float moveX { get; set; }
        public float moveY { get; set; }

        public int Energy { get; set; }


        public Ball(Point Center) {
            this.Energy = 0;
            Random random = new Random();
            this.Center = Center;
            this.Velocity = 10;
            this.Angle = random.NextDouble() * 2 * Math.PI;
            this.Radius = random.Next(20, 40);
            this.moveY= (float)(Math.Sin(Angle) * Velocity);
            this.moveX= (float)(Math.Cos(Angle) * Velocity);
        }


        public Color getColor() {

            if (Energy < 5) {
                return Color.Red;

            }

            if (Energy < 10) {
                return Color.Green;
            }
            return Color.Black;
        }



        public void Draw(Graphics g, Font font) {
            Brush b = new SolidBrush(getColor());
            Brush fb = new SolidBrush(Color.White);

            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            g.DrawString(string.Format("{0}", Energy), font, fb, Center.X, Center.Y);


            b.Dispose();
            fb.Dispose();

        
        }


        public void move(int top, int left, int width, int height) {
            int nextX = (int)(Center.X + moveX);
            int nextY = (int)(Center.Y + moveY);

            int lft = left + Radius;
            int tp = top + Radius;
            int rght = left + width - Radius;
            int btm = top + height - Radius;


            if (nextX <= lft + Radius) {
                nextX = (int)(lft + (lft - nextX));
                moveX = -moveX;


            }

            if (nextX >= rght) {
                nextX = (int)(rght - (nextX - rght));
                moveX = -moveX;
            }

            if (nextY <= tp) {
                nextY = (int)(tp + (tp - nextY));
                moveY = -moveY; 

            }

            if (nextY >= btm) {
                nextY = (int)(btm - (nextY - btm));
                moveY = -moveY;
            }


            Center = new Point(nextX, nextX);
        
        }



        public bool isNear(Ball b) {
            return Math.Sqrt(Math.Pow(Center.X - b.Center.X, 2) + Math.Pow(Center.Y - b.Center.Y, 2)) <= Radius;

        
        }
    }
}
