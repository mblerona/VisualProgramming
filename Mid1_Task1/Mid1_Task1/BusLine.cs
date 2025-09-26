using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid1_Task1
{
    public class BusLine
    {
        public string Destination { get; set; }
        public int Hour { get; set; }   
        public int Minute { get; set; }
        public int Price { get; set; }

        public BusLine(string destination, int hour, int minute, int price)
        {
            Destination = destination;
            Hour = hour;
            Minute = minute;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0:D2}:{1:D2} - {2} - {3} den", Hour,Minute,Destination,Price);
        }
    }
}
