using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2
{
    class Product
    {

        int productId;

        string model;
        string brand;
        int price;

        internal Product()
        {
            Console.WriteLine("Product Default Constructor Called");
        }

        internal Product(int productId, string model, string brand, int price)
        {
            Console.WriteLine("Product Parameterized Constructor Called");
            this.productId = productId;
            this.model = model;
            this.brand = brand;
            this.price = price;
        }
        protected void SetProductData(int productId, string model, string brand, int price)
        {
            this.productId = productId;
            this.model = model;
            this.brand = brand;
            this.price = price;
        }

        internal virtual void Display()
        {
            Console.WriteLine($"ID : {productId} Brand : {brand} Model : {model} Price : Rs.{price}");

        }
    }
}
