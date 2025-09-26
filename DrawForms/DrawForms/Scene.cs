using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawForms
{
    public class Scene
    {

        public List<Shape> Shapes { get; set; }
        public Shape selectedShape { get; set; }


        public Scene()
        {
            Shapes = new List<Shape>();
        }

        public void addShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void DrawAll(Graphics g) { 
        foreach(Shape s in Shapes) {
                s.Draw(g);
            }
        
        }

        public  void Click(Point location ,string type)
        {

            bool Found = false;
            foreach(Shape s in Shapes) {
                if (s.isHit(location))
                {
                    Found = true;
                    s.Selected = !s.Selected;
                }

            }

            if(!Found)
            {
                if (type == "Circle")
                {
                    Shapes.Add(new Circle(Color.Red, 30, location));
                }
                else {
                    Shapes.Add(new Square(Color.Red, 30, location));
                }
               
            }
        }

        public void Pulse() {
            foreach (Shape s in Shapes) {
                s.Pulse();

            }
        
        }
    }
}
