using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_June25
{
    public class Scene
    {
        public List<Ball> Balls;
        public int Width {  get; set; }
        public int Height{  get; set; }

        public Scene(int Height, int Width) {
            this.Height = Height;   
            this.Width = Width; 
            Balls= new List<Ball>();

        }


        public void AddBall(Ball b)
        {
            Balls.Add(b);
        }

        public void DrawAll(Graphics g) { 
        
        foreach(Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        //public void Move() {
        //    foreach (Ball b in Balls) {

        //        b.move(Width,Height);
        //    }

        //}

        public void Move()
        {
            foreach (Ball b in Balls)
            {
                if (!b.isMoving)
                    continue;

                foreach (Ball other in Balls)
                {
                    if (other == b || other.isMoving == true) continue;

                    if (b.CollidesWith(other))
                    {
                        b.isMoving = false;
                        b.Color = Color.Gray;
                        break;
                    }
                }

                if (b.isMoving)
                    b.move(Width, Height);
            }
        }


    }
}
