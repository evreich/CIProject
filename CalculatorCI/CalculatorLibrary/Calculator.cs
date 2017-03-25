using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : ICalculator
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Second parameter is equal zero.");
            return a / b;
        }
    }
}
