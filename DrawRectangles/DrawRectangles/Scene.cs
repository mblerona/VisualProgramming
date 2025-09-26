using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawRectangles
{
    public class Scene
    {
       public List<Rectangle> Rectangles;
       public Scene() {

            Rectangles = new List<Rectangle>();
        }

        public void DrawAll(Graphics g) { 
        foreach(Rectangle rect in Rectangles) { 
            rect.DrawRectangle(g);
            }
        }


        public  void addRectangle(Point p , int width, int height,Color color) {
            
            Rectangles.Add(new Rectangle(p, width, height, color));
        }

        public void Select(Point p)
        {
            foreach (Rectangle r in Rectangles)
            {
                r.Select(p);
            }
        }

    }
}
