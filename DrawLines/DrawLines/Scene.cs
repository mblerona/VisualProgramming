using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    public class Scene
    {
        public List<Line>Lines {  get; set; }
        public Point LastPoint { get; set; }
        public Color Color { get; set; } = Color.Red;
        public int Thickness { get; set; } = 1;

        public bool Positioner { get; set; } = false;
        public Point CursorPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Stack<Line> UndoLines { get; set; }




        public Scene(int Width,int Height) { 
            Lines = new List<Line>();   
            Color = Color.Red;
            Thickness = 1;
            LastPoint= Point.Empty;
            Positioner = false;
            this.Width = Width;
            this.Height=Height;
            UndoLines = new Stack<Line>();


        }


        public void AddPoint(Point point) {
            if (!LastPoint.IsEmpty)
            {
                Lines.Add(new Line(LastPoint, point, Color, Thickness));
            }    
                LastPoint = point;
          
        }

        public void DrawAll(Graphics g) { 
        
        foreach(Line line in Lines) {
                line.Draw(g);

            }

            if (Positioner) {
                Pen p = new Pen(Color.Green, 2);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(p, new Point(0, CursorPoint.Y), new Point(Width,CursorPoint.Y));
                g.DrawLine(p, new Point(CursorPoint.X, 0), new Point(CursorPoint.X,Height));

                p.Dispose();

            }


           
        }


        public void Undo() {

            if (Lines.Count > 0) {
                Line removedLine = Lines[Lines.Count - 1];
                UndoLines.Push(removedLine);
                Lines.RemoveAt(Lines.Count - 1);

                if (Lines.Count == 0)
                {
                    LastPoint = Point.Empty;
                }
                else {
                    LastPoint = Lines[Lines.Count - 1].p2;
                }
               
            }

        }

        public void Redo()
        {
            if (UndoLines.Count > 0) {
                Line addedLine = UndoLines.Pop();
                Lines.Add(addedLine);
                LastPoint = addedLine.p2;

            }
        }
    }
}
