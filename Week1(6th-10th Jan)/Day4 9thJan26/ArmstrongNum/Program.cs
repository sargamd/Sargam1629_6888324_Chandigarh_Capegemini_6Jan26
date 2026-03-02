using System.Numerics;

namespace ArmstrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output;
            Console.Write("Enter number: ");
            int num=int.Parse(Console.ReadLine());
            if (num < 0) { output = -1; Console.Write(output);return; }
            double count = 0;double sum = 0;int y1 = num;
            while (y1 > 0)
            {
                int x = y1 % 10;
                count++;
                y1 = y1/ 10;
            }
            y1 = num;
            if (count > 3) { output = -2;Console.Write(output); return; }
            while (y1 > 0)
            {
                int x = y1 % 10;
                sum = sum+Math.Pow(x,count);
                y1 = y1 / 10;
            }
            if (sum == num) { output = 1; Console.Write(output); }
            else { output = 0; Console.Write(output); }

        }
    }
}
