using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid1_Task1
{
    public class Bus
    {
        public string Registration { get; set; }
        public string Name { get; set; }
        public bool isLocal { get; set; }
        public List<BusLine>BusLines { get; set; }

        public Bus(string registration, string name, bool isLocal)
        {
            Registration = registration;
            Name = name;
            this.isLocal = isLocal;
            BusLines = new List<BusLine>();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Name, Registration, isLocal ? "L" : "M");

        }
    }
}
