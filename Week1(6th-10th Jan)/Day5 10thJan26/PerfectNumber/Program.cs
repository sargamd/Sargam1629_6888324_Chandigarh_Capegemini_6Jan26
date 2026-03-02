namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;int sum = 0;int output=0;
            Console.Write("Enter number: ");
            n=int.Parse(Console.ReadLine());
            if (n < 0) { output = -2;goto print; }
            for(int i = 1; i < n; i++)
            {
                if (n%i== 0) { sum = sum + i; }
            }
            Console.WriteLine(sum);
            if (sum == n) { output = 1; }
            else { output = -1; }


            print:
            Console.WriteLine("Output: " + output);

        }
    }
}
