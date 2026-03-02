namespace MultiplyPositiveNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;int product = 1;
            Console.WriteLine("Enter size of array: ");
            size=int.Parse(Console.ReadLine());
            if(size<0 ) { product = -2; Console.Write(product); return; }
            int[] arr=new int[size];
            Console.WriteLine("Enter Elements:");
            for(int i=0; i<size; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            foreach(int i in arr)
            {
                if (i > 0) { product = product * i; }
            }
            Console.WriteLine("Product: "+product);
        }
    }
}
