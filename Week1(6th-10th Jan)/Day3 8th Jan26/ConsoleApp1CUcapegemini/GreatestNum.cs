using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class GreatestNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");
            int x=int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if(x>y && y > z) { Console.WriteLine("The greatest number is "+x); }
            if(y>z && y > x) { Console.WriteLine("The greatest number is "+y); }
            else {  Console.WriteLine("The greatest number is "+z); }
            
            
            


        }
    }
}
