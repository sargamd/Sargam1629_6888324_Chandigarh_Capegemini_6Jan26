using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class ReturnDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num < 2) { return; }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0}*{1}={2}", num, i, num * i);
            }
        }
    }
}
