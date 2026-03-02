using System.Text.RegularExpressions;

namespace DateExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string input=Console.ReadLine();
            string pattern = @"\d{2}/\d{2}/\d{4}";
            foreach(Match m  in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
