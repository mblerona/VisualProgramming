using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_June25
{
    public class Ball
    {
        public static int Radius { get; set; } = 25;
        public Color Color { get; set; } = Color.Red;
        public int Energy { get; set; } = 50;
        public int dx { get; set; } = 20;
        public int dy { get; set; } = 20;

        public Point Center { get; set; }

        Random Random =new Random();
        public int MoveDirection { get; set; }

        public bool isMoving { get; set; } = true;

        public Ball(Point Center, int MoveDirection) {

            this.Color = Color.Red;
            this.Energy = 500;
            this.MoveDirection = MoveDirection;
            this.Center = Center;
                }


        public void Draw(Graphics g) {
            Brush brush = new SolidBrush(this.Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();
        
        }

        public bool CollidesWith(Ball other)
        {
            double distance = Math.Sqrt(Math.Pow(this.Center.X - other.Center.X, 2) +
                                        Math.Pow(this.Center.Y - other.Center.Y, 2));

            return distance <= Radius * 2;
        }


        public void move(int width, int height) {
            if (!isMoving) {
                return;
            }

            if (MoveDirection == 0)
            { //horizontal
                Center = new Point(Center.X+dx, Center.Y );
                if (Center.X - Radius <= 0 || Center.X + Radius >= width) {
                    dx *= -1;
                    Energy -= 10;
                }
            }
            else { //vertical
                Center = new Point(Center.X , Center.Y + dy);
                if(Center.Y - Radius <=0 || Center.Y+ Radius>= height) {
                    dy *= -1;
                    Energy -= 10;
                }

            }

            if (Energy == 0) { 
            isMoving = false;
                Color = Color.Gray;
            }
           
        
        }

    }
}
