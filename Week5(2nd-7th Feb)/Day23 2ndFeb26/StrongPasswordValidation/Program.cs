using System.Text.RegularExpressions;

namespace StrongPasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password: ");
            string input=Console.ReadLine();
            string pattern= @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";
            //string pattern = @"^.+[A-Z].+[a-z].+\d.+[@$!%*?&].+{8,}$";
            if (Regex.IsMatch(input, pattern)) { Console.WriteLine("Strong"); }
            else { Console.WriteLine("Weak"); }

        }
    }
}
