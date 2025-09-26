using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFormsMe
{
    public class Square : Shape
    {

        public Point StartPoint { get; set; }
        private int coeff { get; set; }

        public Square(Color color, int size,Point startPoint) : base(color, size)
        {
            this.StartPoint= startPoint;
            coeff = -1;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color);
            g.FillRectangle(b, StartPoint.X , StartPoint.Y, Size,Size);
            if (SelectedShape)
            {
                Pen p = new Pen(Color.Green, 2);
                g.DrawRectangle(p, StartPoint.X, StartPoint.Y, Size, Size);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool isHit(Point p)
        {
            Rectangle r = new Rectangle(StartPoint.X, StartPoint.Y, Size, Size);
            return r.Contains(p);
        }

        public override void Pulse()
        {
            Size += (coeff * 4);
            if (Size >= 50 || Size <= 10)
            {
                coeff *= -1;
            }
        }
    }
}
