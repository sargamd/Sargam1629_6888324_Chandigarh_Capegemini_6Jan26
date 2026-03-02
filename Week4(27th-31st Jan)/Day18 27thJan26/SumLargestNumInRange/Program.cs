namespace SumLargestNumInRange
{
    internal class Program
    {
        public static int SumLargestNum(int[] arr,int n)
        {
            
            int sum=0;int output=0,res=0;
            foreach(int i in arr)
            {
                if (i < 0) { output = -1; }
                else if (i == 0 || i > 100) { res = -2; }
            }
            if (output == -1 && res == -2) { sum = -3;goto print; }
            else
            {
                if (output == -1) { sum = -1; goto print; }
                if (res == -2) { sum = -2;goto print; }
            }
                       
            int[] max = new int[10];

            foreach (int i in arr)
            {
                int x = (i-1) / 10;
                if (max[x] < i) { max[x] = i; }
                
            }
            foreach(int i in max)
            {
                sum = sum + i;
            }
            print:
                return sum;


        }
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n=int.Parse(Console.ReadLine());
            int[] arr= new int[n];
            Console.WriteLine("Enter Elements: ");
            for(int i=0;i<n;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum: "+SumLargestNum(arr,n));
        }
    }
}
