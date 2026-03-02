using System.Drawing;

namespace DecimlToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;int output;
            Console.Write("Enter Decimal number: ");
            num=int.Parse(Console.ReadLine());
            int count = 0;
            int n = num;
            while (n > 0)
            {
                n = n / 2;
                count++;
            }
            int size = count;
            
            //Console.WriteLine(size);
            int[] arr = new int[size];
            if (num < 0) { output = -1; Console.Write(output); return; }
            int i = 0;
            while (num > 0)
            {
                int x = num % 2;
                arr[i] = x;
                i++;
                num = num / 2;
            }
            Array.Reverse(arr);
            foreach(int x in arr) {  Console.Write(x); }

        }
    }
}
