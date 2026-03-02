namespace sumcubeofPrimeNum
{
    internal class Program
    {
        static bool Primenum(int n)
        {
            int i = 2;
            if (n == 1) { return false; }
            while (i < n)
            {
                if (n % i == 0) {  return false; }
                else { i++; }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;int sum = 0;
            Console.Write("Enter no. limit: ");
            n=int.Parse(Console.ReadLine());
            
            if (n < 0) { sum = -1; goto print; };
            if (n > 7) { sum = -1; goto print; };
            for(int i = 1; i <= n; i++)
            {
                if (Program.Primenum(i)) { sum = sum + (i * i * i); }
            }
            

        print:
            Console.WriteLine("Sum: " + sum);

        }
    }
}
