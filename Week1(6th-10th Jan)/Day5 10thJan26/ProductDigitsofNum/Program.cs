namespace ProductDigitsofNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;int product = 1;
            Console.Write("Enter number: ");
            num=int.Parse(Console.ReadLine());
            int y = num;
            while (y > 0)
            {
                int x = y % 10;
                product = product * x;
                y = y / 10;
            }
            if (num < 0) { product = -1; }
            else if(num%5==0||num%3==0) { product = -2; }
            else if (product % 5 == 0 || product % 3 == 0) { product = 1; }
            Console.Write(product);
        }
    }
}
