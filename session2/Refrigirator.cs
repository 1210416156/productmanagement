using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2
{
    class Refrigirator : Product
    {
        int capacity;
        int rating;
        string doors;

        internal Refrigirator()
        {
            Console.WriteLine("Refrigirator Default Constructor Called");
        }

        internal Refrigirator(int productId, string model, string brand, int price,
            int capacity, int rating, string doors) : base(productId, model, brand, price) 
        {
            Console.WriteLine("Refrigirator Parameterized Constructor Called");
            this.capacity = capacity;
            this.rating = rating;
            this.doors = doors;
        }

        internal void SetRefrigiratorData(int productId, string model, string brand, int price,
            int capacity, int rating, string doors)
        {
            base.SetProductData(productId, model, brand, price);
            this.capacity = capacity;
            this.rating = rating;
            this.doors = doors;
        }

        internal override void Display()
        {
            base.Display();
            Console.WriteLine($"Capacity : {capacity} Rating : {rating} DisplayGlass : {doors}");

        }
    }
}
