namespace SumEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int sum = 0;
            int num=int.Parse(Console.ReadLine());
            if (num > 32767) { sum = -2; Console.Write(sum); return; }
            while (num > 0)
            {
                int x = num % 10;
                if (x % 2 == 0) { sum = sum + x; }
                num = num / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
