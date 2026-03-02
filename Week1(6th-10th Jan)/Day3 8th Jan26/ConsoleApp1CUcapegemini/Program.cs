namespace ConsoleApp1CUcapegemini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x, y;
            Console.Write("Enter x value");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter y value");
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if(y > x)
            {
                Console.WriteLine("x is less than y");
            }
            else
            {
                Console.WriteLine("Both are equal");
            }
        }
    }
}
