namespace SumofFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;int limit;int sum = 0;
            Console.Write("Enter Number: ");
            num=int.Parse(Console.ReadLine());
            if (sum < 0) { sum = -1;goto print; }
            Console.Write("Enter limit: ");
            limit=int.Parse(Console.ReadLine());
            if (limit > 32627) { limit = -2;goto print; }
            int i = 1;
            while (i <= limit)
            {
                if (i % num == 0)
                {
                    sum = sum + i;
                }
                i++;
            }
            print:
                Console.WriteLine("Sum: " + sum);
        }
    }
}
