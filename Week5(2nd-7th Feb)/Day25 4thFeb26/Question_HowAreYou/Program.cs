using System.Text.RegularExpressions;

namespace Question_HowAreYou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter name : ");
            string name = Console.ReadLine(); // Name

            //string combined = input1 + input2;

            
            string pattern = @"^.{16,}$";

            if (Regex.IsMatch(name,pattern))
            {
                Console.WriteLine("Name is more than 15 characters");
            }
            else
            {
                Console.WriteLine("Hi how are you Dear " + name);
            }
        }
    }
}
