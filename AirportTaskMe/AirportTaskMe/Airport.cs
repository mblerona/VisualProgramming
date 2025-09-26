using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportTaskMe
{
    public class Airport
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public List<Destination> Destinations= new List<Destination>();

        public Airport(string city, string name, string shortcut)
        {
            City = city;
            Name = name;
            Shortcut = shortcut;
        }

        public override string ToString()
        {
            return String.Format("{0}  {1} - {2}", City,Name,Shortcut);
        }
    }
}
