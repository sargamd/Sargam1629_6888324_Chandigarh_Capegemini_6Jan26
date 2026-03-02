using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class ChangeArraySize_RunTime
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 50, 10, 40, 60, 20, 30 };
            Console.WriteLine("Element of array are: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("Enter the new size of array: ");

        }
    }
}
