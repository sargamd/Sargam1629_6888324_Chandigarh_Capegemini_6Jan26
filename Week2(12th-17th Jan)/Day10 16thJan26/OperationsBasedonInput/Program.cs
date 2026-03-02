namespace OperationsBasedonInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers: ");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            Console.WriteLine(" 1. Add   2. Subtract   3. Multiply    4. Integer Quotient");
            Console.Write("Enter Choice: ");
            int ch=int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Enter 1,2,3");
                    break;

            }

        }
    }
}
