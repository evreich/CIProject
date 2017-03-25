using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface ICalculator
    {
        int Addition(int a, int b);
        int Substraction(int a, int b);
        int Multiplication(int a, int b);
        int Division(int a, int b);
    }
}
