using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls;
        public Random random;
        Font font;

        public Scene() {
            Balls = new List<Ball>();
            random = new Random();
            font=new Font("Arial", 15);
        }


        public void AddBall(Ball b) { 
        
        Balls.Add(b);   
        }

        public void DrawAll(Graphics g) { 
        foreach(Ball b in Balls) {

                b.Draw(g, font);
            }
        
        }

        public void MoveBalls(int top, int left, int width, int height) {
            foreach (Ball ball in Balls)
            {
                ball.move(top, left, width, height);
            }
        }

        public void checkCollisions() { 
                for(int i =0; i<Balls.Count; i++) {
                for (int j = 1; j < Balls.Count; j++) {
                    if (i != j && Balls[i].isNear(Balls[j])) {
                        if (Balls[i].Radius > Balls[j].Radius)
                        {
                            Balls[i].Energy += 1;
                            Balls[j].Energy -= 1;
                        }
                        else {
                            Balls[i].Energy -= 1;
                            Balls[j].Energy += 1;
                        }
                    }
                }
                }

            for (int i = Balls.Count - 1; i >= 0; i--)
            {
                if (Balls[i].Energy < 0)
                {
                    Balls.RemoveAt(i);
                }
            }


        }
    }
}
