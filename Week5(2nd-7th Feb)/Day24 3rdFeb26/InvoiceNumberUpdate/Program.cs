using System.Text.RegularExpressions;

namespace InvoiceNumberUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter invoice number: ");
            string input1=Console.ReadLine();
            Console.Write("Increment value: ");
            int incre=int.Parse(Console.ReadLine());
            int num = 0;
            string pattern = @"\d+";
            //foreach (Match m in Regex.Matches(input1, pattern))
            //{
            //    num = int.Parse(m.Value);
            //}
            Match m=Regex.Match(input1, pattern);
            num = int.Parse(m.Value) + incre;
            //Console.WriteLine("CAP-"+Convert.ToString(num));
            string result=Regex.Replace(input1,pattern,Convert.ToString(num));
            Console.WriteLine(result);

        }
    }
}
