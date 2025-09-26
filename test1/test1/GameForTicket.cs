using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class GameForTicket
    {
        public Game Game { get; set; }
        public int Tip { get; set; }

        public GameForTicket(Game game, int tip)
        {
            Game = game;
            Tip = tip;
        }

        public override string ToString()
        {
            return String.Format("{0}  {1}", Game.ToString(), Tip==0? "1" : Tip == 2? "X" : "2" );
        }
    }
}
