using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Bill
    {
        public DateTime DateTime { get; set; }
        public int totalPrice { get; set; }



        public override string ToString()
        {
            return String.Format("{0} {1} - {2} den", DateTime.ToShortTimeString(), DateTime.ToShortDateString(),totalPrice); ;
        }
    }
}
