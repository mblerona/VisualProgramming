using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFormsMe
{
    public class Circle : Shape
    {
        public Point Center { get; set; }
        private int  coeff=-1;

        public Circle(Color color, int size, Point center ) : base(color, size)
        {
            this.Center = center;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color);
            g.FillEllipse(b, Center.X - Size, Center.Y - Size, 2 * Size, 2 * Size);
            if (SelectedShape) {
                Pen p = new Pen(Color.Green, 2);
                g.DrawEllipse(p, Center.X - Size, Center.Y - Size, 2 * Size, 2 * Size);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool isHit(Point p)
        {
            return Math.Sqrt(Math.Pow(Center.X-p.X,2) + Math.Pow(Center.Y-p.Y, 2)) <= Size;
        }

        public override void Pulse()
        {
            Size += (coeff * 2);
            if (Size >= 20 || Size <= 10) {
                coeff *= -1;
            }
        }
    }
}
