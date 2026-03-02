namespace Avgnumdivisibleby5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;double avg;double sum = 0;
            Console.Write("Enter limit of number: ");
            n=int.Parse(Console.ReadLine());
            if (n < 0) { avg = -1;goto print; }
            for(int i= 1; i <= n; i++)
            {
                if (i % 5 == 0) { sum = sum + i; }
            }
            avg = sum / n;
            print:
                Console.WriteLine(avg);
        }
    }
}
