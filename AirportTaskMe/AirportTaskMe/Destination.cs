using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirportTaskMe
{
    public  class Destination
    {
        public string Name { get; set; }
        public double Distance { get; set; }
        public int Price { get; set; }

        public Destination(string name, double distance, int price)
        {
            Name = name;
            Distance = distance;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}km  - {2}eur", Name, Distance, Price);
        }
    }
}
