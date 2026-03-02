using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class oddnum_evennumSum
    {
        static void Main(string[] args)
        {
            float avg = 0;
            Console.Write("Enter size of array: ");
            int size=Convert.ToInt32(Console.ReadLine());
            if (size < 0)
            {
                avg = -2;
                Console.WriteLine("Output: "+avg);
                return;
            }
            int[] arr=new int[size];
            Console.WriteLine("Enter elements:");
            for(int i = 0; i < size; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    avg = -1;
                    Console.WriteLine("Output: "+avg);
                    return;
                }
            }
            int sumodd=0, sumeven=0;
            foreach(int i in arr)
            {
                if (i % 2 == 0) { sumeven = sumeven + i; }
                else { sumodd = sumodd + i; }
            }
            avg = (sumodd + sumeven) / 2;
            Console.WriteLine("Average: "+avg);
        }
    }
}
