namespace Sum_Square_oddDigitInNum__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;int sum = 0;
            Console.Write("Enter number: ");
            num=int.Parse(Console.ReadLine());
            if (num < 0) { sum = -1;goto print; }
            while (num > 0)
            {
                int x = num % 10;
                if (x % 2 != 0) { sum = sum + (x * x); }
                num = num / 10;
            }
            print:
                Console.WriteLine(sum);
        }
    }
}
