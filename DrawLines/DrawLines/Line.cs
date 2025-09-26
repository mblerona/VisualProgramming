using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    public class Line
    {
        public Point p1 {  get; set; }
        public Point p2 { get; set; }

        public Color Color { get; set; }
        public int Thickness { get; set; }

        public Line(Point p1, Point p2, Color color, int thickness)
        {
            this.p1 = p1;
            this.p2 = p2;
            Color = color;
            Thickness = thickness;
        }

        public void Draw(Graphics g) {

            Pen p = new Pen(this.Color,this.Thickness);
            g.DrawLine(p, p1, p2);
            p.Dispose();

        }



    }
}
