using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public int Multiply(int x, int y) => x * y;
        public double Divide(int x, int y)
        {
            if (y == 0) { throw new DivideByZeroException("Cannot Divide by zero"); }
            return (double)x / y;
        }
    }
}
