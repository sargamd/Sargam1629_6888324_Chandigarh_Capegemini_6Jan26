using System;

namespace PalindromeCheck
{
    internal class Program
    {
        public static bool Palindromchk(string str)
        {
            char[] r = new char[str.Length];
            bool chk=false;
            //string r;
            //r.ToCharArray();
            str.ToCharArray();
            int i = 0; int n = str.Length - 1;
            while (i < str.Length)
            {
                r[n] = str[i];
                n--;
                i++;

            }
            //r.ToString();
            for(int j=0;j< r.Length; j++)
            {
                if (r[j] == str[j])
                {
                    chk= true;
                }
                else { chk = false; }
            }
            return chk;

            //Console.WriteLine(r);
            


        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(Palindromchk(str));
        }
    }
}
