using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawForms
{
    public class Circle : Shape
    {

        public Point center {  get; set; }
        private int coeff = -1;
        public Circle(Color color, int size, Point center) : base(color, size)

        {
            this.center = center;
            this.coeff = -1;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color);
            g.FillEllipse(b, center.X - Size, center.Y - Size, 2 * Size, 2 * Size);

            if (Selected) { 

                Pen p = new Pen(Color.Yellow,2);
                g.DrawEllipse(p, center.X - Size, center.Y - Size, 2 * Size, 2 * Size);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool isHit(Point p)
        {
            return (Math.Sqrt(Math.Pow(center.X - p.X, 2) + Math.Pow(center.Y - p.Y, 2))) <= Size;
        }


        public override void Pulse()
        {
            Size += (coeff * 3);
            if(Size>=30 || Size <= 5)
            {
                coeff *= -1;
            }

        }
    }
}
