using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class AdvancedCalculator : INumberOperations
    {
        public int Add(int number1, int number2)
        {
            if (number1 < 0 || number2 < 0)
                return 0;
            else
                return number1 + number2;
        }

        public bool Compare(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int number1, int number2)
        {
            throw new NotImplementedException();
        }

    }
}
