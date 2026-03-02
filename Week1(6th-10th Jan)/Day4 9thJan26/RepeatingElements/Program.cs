namespace RepeatingElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter size: ");
            size=int.Parse(Console.ReadLine());
            int[] arr=new int[size];
            Console.WriteLine("Enter Elements:");
            for(int i=0;i<size;i++)
            {
                arr[i]=int.Parse(Console.ReadLine()) ;
            }
            int max = arr[0];
            foreach(int i in arr)
            {
                if (max < i) { max=i; }
            }
            int[] output=new int[max+1];
            foreach(int i in arr)
            {
                output[i]++;
            }
            int count = 0; max = output[0];
            foreach (int i in output)
            {
                if (max < i) { max = i; }
            }
            Console.Write("Max Repeated elements: ");
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == max)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
