using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawFormsMe
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public int Size { get; set; }
        public bool SelectedShape  {get;set;}

        protected Shape(Color color, int size)
        {
            Color = color;
            Size = size;
            SelectedShape = false;
        }

        public abstract void Draw(Graphics g);
        public abstract void Pulse();
        public abstract bool isHit(Point p);
    }
}
