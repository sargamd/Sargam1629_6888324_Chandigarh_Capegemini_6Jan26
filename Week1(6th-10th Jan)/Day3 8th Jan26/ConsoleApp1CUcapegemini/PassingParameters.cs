using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class PassingParameters
    {
        void test1()
        {
            Console.WriteLine("no parameter no return type");
        }
        void test2(int x)
        {
            Console.WriteLine("1 parameter no return type");
        }
        string test3()
        {
            return "no parameter with return type";
        }
        string test4(string name)
        {
            return "Hello " + name;
        }

        //returning multiple values
        void math1(int x, int y, ref int a, ref int b)
        {
            a = x + y;
            b = x * y;
        }
        //method returning multiple values using out parameter

        void math2(int x,int y,out int a,out int b)
        {
            a = x - y;
            b = x / y;
        }

        static void Main(string[] args)
        {
            PassingParameters p=new PassingParameters();
            p.test1();
            p.test2(100);
            Console.WriteLine(p.test3());
            Console.WriteLine(p.test4("Ria"));

            int m = 0, n = 0;
            p.math1(100, 50, ref m, ref n);
            Console.WriteLine(m+" "+n);

            int q, r;
            p.math2(100,50,out q,out r);
            Console.WriteLine(q+" "+r);
        }
    }
}
