﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccountK1
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("Kod:{0} -  {1}   - {2:F2} mkd", Code,Name,Price);
        }
    }
}
