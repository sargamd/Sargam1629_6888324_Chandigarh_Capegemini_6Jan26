using System.Text.RegularExpressions;

namespace LocationCodeUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter invoice number: ");
            string input=Console.ReadLine();
            Console.Write("Enter location code: ");
            string loc=Console.ReadLine();
            string pattern = @"[A-Z]{3}";
            string p=null;
            foreach(Match m in Regex.Matches(input, pattern))
            {
                if (m.Value != "CAP") { p = m.Value; break; }
            }
            //Match m=Regex.Match(input, pattern);
            string locupdate=Regex.Replace(input,p,loc);
            Console.WriteLine(locupdate);
        }
    }
}
