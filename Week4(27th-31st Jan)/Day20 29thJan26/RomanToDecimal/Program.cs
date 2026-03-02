namespace RomanToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter roman number: ");
            string str=Console.ReadLine();
            Console.Write("Decimal number: "+ UserProgramCode.convertRomanToDecimal(str));
            //int num = UserProgramCode.convertRomanToDecimal(str);
        }
    }
}
