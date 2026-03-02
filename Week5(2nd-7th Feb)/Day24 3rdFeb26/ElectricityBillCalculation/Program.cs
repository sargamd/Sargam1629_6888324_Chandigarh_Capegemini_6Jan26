using System.Text.RegularExpressions;

namespace ElectricityBillCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first meter reading: ");
            string input1=Console.ReadLine();
            Console.Write("Enter second meter reading: ");
            string input2=Console.ReadLine();
            Console.Write("Enter rate per unit: ");
            int rate=int.Parse(Console.ReadLine());
            string pattern = @"\d+";
            int n1=0, n2=0;
            foreach(Match m  in Regex.Matches(input1, pattern))
            {
                n1 = int.Parse(m.Value);
            }
            foreach(Match m in Regex.Matches(input2, pattern))
            {
                n2=int.Parse(m.Value);
            }
            int diff = n1>n2 ? n1-n2 : n2-n1;
            int bill = diff * rate;
            Console.WriteLine("Bill: " + bill);

        }
    }
}
