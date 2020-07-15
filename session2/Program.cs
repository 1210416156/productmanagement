using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2
{
    class Program
    {
        static void Main(string[] args)
        {

            Refrigirator refrigirator = new Refrigirator();
            refrigirator.SetRefrigiratorData(1001,"X1", "LG",20000,120, 5,"Single Door");
            refrigirator.Display();

           
        }

        static void DisplayProduct(Product product)
        {
            if (product.GetType() == typeof(Refrigirator))
                ((Refrigirator)product).Display();

        }
    }
}
