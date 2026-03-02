namespace CountMultiplesof3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;int output=0;int count = 0;
            Console.Write("Enter size: ");
            size= int.Parse(Console.ReadLine());
            if (size < 0) { output= 2; Console.Write("Size -ve, output= " + output); return; }
            int[] arr= new int[size];
            Console.WriteLine("Enter Elements:");
            for(int i = 0; i < size; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            
            foreach(int i in arr)
            {
                if (i<0) { output = 1;break; }
                else if (i % 3 == 0) { count++; output = count; }
            }
            Console.WriteLine("Output: "+output);
        }
    }
}
