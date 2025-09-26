using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFormsMe
{
    public  class Scene
    {
        public List<Shape> Shapes {  get; set; }
        public Shape selected {  get; set; }

        public Scene()
        {
            Shapes = new List<Shape> ();
        }

        public void addShape(Shape s) { 
        Shapes.Add (s); 
        }

        public void drawAll(Graphics g ) {
            foreach (Shape s in Shapes) { 
            s.Draw(g);
            }
        
        }

        public void Pulse()
        {
            foreach(Shape s in Shapes) { s.Pulse();}

        }


        public void Click(Point location, string Type) {
            bool Found = false;
            foreach(Shape s in Shapes)
            {
                if (s.isHit(location)) {
                    Found = true;
                    s.SelectedShape = !s.SelectedShape;
                }

            }

            if (!Found) {
                if (Type == "Circle")
                {
                    Shapes.Add(new Circle(Color.Red, 30, location));
                }
                else {
                    Shapes.Add(new Square(Color.Red, 30, location));
                }
            
            }
        
        }
    }
}
