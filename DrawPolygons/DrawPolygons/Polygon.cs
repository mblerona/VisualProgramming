using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DrawPolygons
{
    [Serializable]
    public class Polygon
    {
        
        public List<Point > Points { get; set; }
        public bool isCompleted { get; set; }= false;
        public bool closeToStart { get; set; } = false;

        public Point Cursor { get; set; } = new Point();

        public Polygon()
        {
            Points = new List<Point>();
            
                
        }

        public void addPoint(Point p) {

            closeToStart = NearStart();
            if (closeToStart) {
                Points.Add(Points[0]);
                isCompleted = true;
                closeToStart = false;
            }
            else {
                Points.Add(p);
            }
           

        }


        public void updateCursor(Point p) { 
        Cursor = p;
            closeToStart = NearStart();

        }
        public bool NearStart() {
            if (Points.Count <3) {
                return false;
            }

            Point p1 = Points[0];

            double distance = Math.Sqrt(Math.Pow(p1.X - Cursor.X, 2) + Math.Pow(p1.Y - Cursor.Y, 2));
            return distance <= 5;
        }


        public void Draw(Graphics g)
        {

            Pen p = new Pen(Color.Red, 2);
            Brush b = new SolidBrush(Color.Blue);

            Pen p2 = new Pen(Color.Green);
            p2.DashStyle = DashStyle.Dash;
            
            if(Points.Count >= 2) {
                g.DrawLines(p,Points.ToArray());
                if(closeToStart)
                {
                    Point first = Points[0];
                    g.DrawEllipse(p2, first.X-5, first.Y-5, 10,10);
                }

                if (isCompleted) {
                    g.FillPolygon(b, Points.ToArray());
                }


                if (Points.Count > 0) {
                    Point last = Points[Points.Count - 1];
                    g.DrawLine(p2, last, Cursor);

                }
                p.Dispose();
                p2.Dispose();
                b.Dispose();

            }
            
            
        }
    }
}
