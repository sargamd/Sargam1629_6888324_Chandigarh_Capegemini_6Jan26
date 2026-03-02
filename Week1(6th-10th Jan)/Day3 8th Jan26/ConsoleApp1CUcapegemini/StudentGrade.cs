using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class StudentGrade
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks out of 100: ");
            int marks = int.Parse(Console.ReadLine());
            if (marks >= 90) { Console.WriteLine("Grade A"); }
            else if (marks >= 75 && marks < 90) { Console.WriteLine("Grade B"); }
            else if (marks >= 60 && marks < 75) { Console.WriteLine("Grade C"); }
            else if (marks >= 45 && marks < 60) { Console.WriteLine("Grade D"); }
            else if (marks >= 0 && marks < 45) { Console.WriteLine("Fail"); }
            else { Console.WriteLine("Enter valid marks"); }
        }
    }
}
