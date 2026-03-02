using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class _1DArray
    {
        public static void Main(string[] args)
        {
            int[] arr=new int[5];
            Console.WriteLine("Enter 5 numbers: ");
            for (int i=0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Given Array: ");

            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }

    }
}
