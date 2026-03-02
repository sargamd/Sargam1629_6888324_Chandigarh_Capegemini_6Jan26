namespace CountDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; int count = 0;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                count = -1;
                Console.WriteLine(count);
                return;
            }
            while (num > 0)
            {
                int x = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);

        }
    }
}
