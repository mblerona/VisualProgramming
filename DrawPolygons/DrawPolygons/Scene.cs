using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPolygons
{
    [Serializable]
    public class Scene
    {

        public List<Polygon> Polygons { get; set; }
        Polygon currentPolygon {  get; set; } = new Polygon();

        public Scene() {
            Polygons = new List<Polygon>();

        }

        public void addPoint(Point p) { 

            currentPolygon.addPoint(p);
            if (currentPolygon.isCompleted) { 
             Polygons.Add(currentPolygon);
                
                currentPolygon = new Polygon();
            }
        }

        public void updateCursor(Point p ) {
        currentPolygon.updateCursor(p);
        }

        public void Draw(Graphics g) {
            currentPolygon.Draw(g);

            foreach(Polygon p in Polygons) { 
            p.Draw(g);
            
            }
        
        }

    }
}
