using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public  class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public int Price { get; set; }

        public Product(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}
