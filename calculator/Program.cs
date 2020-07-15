using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            INumberOperations numberOperations = new Calculator();
            int t = numberOperations.Add(-4, -6);
            Console.WriteLine(t);
            numberOperations = new AdvancedCalculator();
            t = numberOperations.Add(-4, -6);
            Console.WriteLine(t);

        }
    }
}
