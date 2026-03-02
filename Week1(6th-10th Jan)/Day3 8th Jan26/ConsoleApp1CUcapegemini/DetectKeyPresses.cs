using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class DetectKeyPresses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key from 0 to 9");
            string ch=Console.ReadLine();
            switch (ch)
            {
                case "0": case "1": case "2":case "3":case "4":case "5":case "6":case "7":case "8":case "9":
                    Console.Write(ch);
                    break;
                default:
                    Console.WriteLine("Invalid Key"); break;
            }
        }
    }
}
