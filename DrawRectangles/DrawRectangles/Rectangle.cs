using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawRectangles
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Point Cursor { get; set; }
        public Color Color { get; set; }
        public bool isSelected { get; set; } = false;

        public Rectangle(Point cursor, int width, int height, Color color)
        {
            Cursor = cursor;
            Width = width;
            Height = height;
            Color = color;
            isSelected = false;
        }
        public void DrawRectangle(Graphics g) { 
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Cursor.X, Cursor.Y, Width, Height);

            Pen p = new Pen(Color.Yellow, 2);
            if(isSelected )
            {
                g.DrawRectangle(p, Cursor.X, Cursor.Y, Width, Height);
            }
        }

        public void Select(Point point) {
            if (point.X >= Cursor.X && point.X <= Cursor.X + Width && point.Y >= Cursor.Y && point.Y <= Cursor.Y + Height) {
                isSelected = !isSelected;
            }
        
        }

        


    }
}
