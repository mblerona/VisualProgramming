using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1Race
{
    public class Lap
    {
        public int minutes {  get; set; }
        public int seconds { get; set; }

        public Lap(int seconds, int minutes )
        {
            this.minutes = minutes;
            this.seconds = seconds;
        }


        public int convertTime(int minutes, int seconds)
        {
            return minutes * 60 + seconds;
        }
        public override string ToString()
        {
            return String.Format("{0:D2}:{1:D2}", minutes,seconds);
        }
    }
}
