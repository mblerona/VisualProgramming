using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }   

        public string Description { get; set; }
        public Order(Product Product, int Quantity) { 
        this.Product = Product;
            this.Quantity = Quantity;
        }

        public Order(Product Product, int Quantity, string Description)
        {
            this.Product = Product;
            this.Quantity = Quantity;
            this.Description = Description;
        }

        public int totalPrice() { 
        return this.Quantity * this.Product.Price;
        }
        public override string ToString()
        {
            return String.Format("{0} x {1} = {2}den", Quantity, Product.Name, totalPrice());
        }
    }
}
