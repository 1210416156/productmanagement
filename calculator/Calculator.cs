using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator : INumberOperations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool Compare(int number1, int number2)
        {
            return number1 < number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

    }
}
