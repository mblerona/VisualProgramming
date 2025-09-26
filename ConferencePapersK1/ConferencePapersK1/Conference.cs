using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePapersK1
{
    public class Conference
    {
        public string ID { get; set; } 
        public string Name { get; set; }
        public int Year { get; set; }

        public Conference(string name, int year)
        {
            Name = name;
            Year = year;
            ID = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return String.Format(" {0}: {1}", Year, Name);
        }
    }
}
