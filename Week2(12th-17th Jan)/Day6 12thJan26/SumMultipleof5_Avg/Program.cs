namespace SumMultipleof5_Avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter size: ");
            size=int.Parse(Console.ReadLine());
            if (size < 0) { int output = -2;Console.Write("output");return; }
            int[] arr=new int[size];
            for(int i = 0;i< size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int i in arr) { if (i < 0) { int output = -1;Console.Write("output");return; } }
            double count = 0;double sum = 0;
            foreach( int i in arr)
            {
                if (i % 5 == 0) { count++; sum = sum + i; }
            }
            //Console.WriteLine(count);
            //Console.WriteLine(sum);
            double avg=sum/count;
            Console.WriteLine(avg);
        }
    }
}
