using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    public class Scene
    {
        public List<Ball> Balls;
        public int Width {  get; set; }
        public int Height { get; set; }
        public int Hits { get; set; } = 0;
        public int Misses { get; set; } = 0;

        public bool isPaused { get; set; } = false;

        public Scene(int width, int height)
        {
            Width = width;
            Height = height;
            Balls = new List<Ball>();
           // Hits = 0;
            //Misses = 0;
            isPaused = false;

        }

        public void Draw(Graphics g) { 
        foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        public void addBall(Ball b) {

            Balls.Add(b);
        }

        public void Move() {
            foreach (Ball b in Balls) { 
                b.Move();
                if (b.Center.X + Ball.RADIUS > Width) {
                    b.colorState = -1;
                }

            }

           for(int i =0; i < Balls.Count; i++) {
                if (Balls[i].colorState == -1) {
                    ++Misses;

                    Balls.RemoveAt(i);
                    
                }
            }
        
        }


        public void HitBalls(Point location) { 

            foreach (Ball b in Balls) {
             if(b.isHit(location))
                {
                    b.colorState++;
                }
               
            }

            for (int i = 0; i < Balls.Count; i++)
            {
                if (Balls[i].colorState == 3)
                {

                    ++Hits;
                    Balls.RemoveAt(i);
                }
            }
        }
    }
}
