using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            int num; int fact = 1;
            Console.WriteLine("Enter number(from 1 to 7): ");
            num=Convert.ToInt32(Console.ReadLine());
            if (num < 0) { fact = -1; }
            else if (num > 7) {  fact = -2; }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;

                }
            }
            Console.WriteLine(fact);
                
        }
    }
}
