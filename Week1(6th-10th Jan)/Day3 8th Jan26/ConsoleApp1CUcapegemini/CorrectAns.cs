using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class CorrectAns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who among the following has never been apponited as The Prime Minister of India?");
            Console.WriteLine("a. Narendra Modi   b.APJ Abdul Kalam    c.Rajiv Gandhi   d.Indira Gandhi");
            Console.WriteLine("Enter the answer choice(a,b,c,d)");
            string ch = Console.ReadLine();
            if (ch == "b" || ch == "B") { Console.WriteLine("Correct Ans"); }
            else if (ch == "a" || ch == "A" || ch == "c" || ch == "C" || ch == "D" || ch == "d") { Console.WriteLine("Incorrect Ans"); }
            else { Console.WriteLine("Enter from a,b,c,d"); }
        }
    }
}
