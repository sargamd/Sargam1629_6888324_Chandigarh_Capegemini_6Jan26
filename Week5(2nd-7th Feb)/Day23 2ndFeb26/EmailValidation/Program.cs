using System.Text.RegularExpressions;

namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Email: ");
            string input=Console.ReadLine();
            string pattern= @"^\w+@\w+.\w+${2,100}";

            if(Regex.IsMatch(input, pattern)) { Console.WriteLine("Valid"); }
            else { Console.WriteLine("Invalid"); }
        }
    }
}
