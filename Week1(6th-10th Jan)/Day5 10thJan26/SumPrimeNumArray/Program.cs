namespace SumPrimeNumArray
{
    internal class Program
    {
        static int PrimeNum(int n)
        {
            int i = 2;
            if (n == 1) { return 0; }
            while (i<n)
            {
                if (n % i == 0) { return 0; }
                else { i++; }
                
            }
            return 1;
        }
        static void Main(string[] args)
        {
            
            int size;int sum = 0;
            Console.Write("Enter size: ");
            size=int.Parse(Console.ReadLine());
            if (size < 0) { sum = -2;Console.Write(sum); return; }
            int[] arr=new int[size];
            for(int i=0; i<size; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            
            foreach(int i in arr)
            {
                if (i < 0) { sum = -1; break; }
                if (Program.PrimeNum(i) == 1) { sum = sum + i; }
            }
            if(sum == 0) { sum = -3; }
            Console.WriteLine("Output: "+sum);



        }
    }
}
