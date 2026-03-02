using System.Text.RegularExpressions;

namespace HashTagExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input=Console.ReadLine();
            string pattern = @"#+[\w]+";
            
            foreach(Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}
