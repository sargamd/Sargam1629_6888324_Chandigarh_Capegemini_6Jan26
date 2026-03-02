using System.Text.RegularExpressions;

namespace PhoneNumExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input=Console.ReadLine();
            string pattern = @"\d{10}";
            foreach(Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
