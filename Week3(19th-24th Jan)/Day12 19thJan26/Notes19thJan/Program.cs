using System;

namespace Notes19thJan
{
    internal class Person
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Obect class is the base class in .net
            object obj1 = 42;
            Console.WriteLine(obj1.ToString()); // "42"

            object obj2 = "Hello";
            Console.WriteLine(obj2.GetType()); // System.String

            object obj3 = new Person();
            Console.WriteLine(obj3.Equals(new Person())); // False (different references)
            Console.WriteLine();

            //2.Equals func vs ==
            string s1 = "hello";
            string s2 = "hello";
            Console.WriteLine(s1.Equals(s2)); // True (value comparison)  
            Console.WriteLine(s1 == s2);      // True (string overrides ==)
            Console.WriteLine();

            object o1 = new object();
            object o2 = new object();
            Console.WriteLine(o1.Equals(o2)); // False  
            Console.WriteLine(o1 == o2);      // False (different references)

            int a = 5, b = 5;
            Console.WriteLine(a.Equals(b)); // True  
            Console.WriteLine(a == b);      // True (value types)





        }
    }
}
