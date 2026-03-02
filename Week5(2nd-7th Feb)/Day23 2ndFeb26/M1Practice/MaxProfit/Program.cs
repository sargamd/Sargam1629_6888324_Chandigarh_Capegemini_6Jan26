namespace MaxProfit
{
    internal class Program
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                for(int j = i + 1; j < prices.Length; j++)
                {
                    int buy = prices[i];
                    int sell=prices[j];
                    if (max < (sell - buy))
                    {
                        max = sell - buy;
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            int[] prices = new int[size];
            Console.WriteLine("Enter prices: ");
            for(int i = 0; i < size; i++)
            {
                prices[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(MaxProfit(prices));
        }
    }
}
