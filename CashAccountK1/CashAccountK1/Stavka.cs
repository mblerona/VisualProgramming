using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccountK1
{
    public class Stavka
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Stavka(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal totalPrice() {
           
            return Product.Price * Quantity;
        }

        public override string ToString()
        {
            return String.Format("{0}  ->  {1} x {2}  =  {3:F2}", Product.Name, Product.Price, Quantity, totalPrice());
        }
    }
}
