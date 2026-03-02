using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void Math(int x,int y);
    internal class Multiclass
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("Add: "+(x+y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Subtract: " + (x - y));
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply: " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("Divide: " + (x / y));
        }
    }
}
