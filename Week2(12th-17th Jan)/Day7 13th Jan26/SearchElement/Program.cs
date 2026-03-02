namespace SearchElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size; int output = -3;
            Console.Write("Enter size: ");
            size = Convert.ToInt32(Console.ReadLine());
            if (size < 0) { output = -2; Console.Write(output); return; }
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                
            }
            foreach(int i in arr) { if (i < 0) { output = -1;goto print; } }
            Console.Write("Element to be searched: ");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (int i in arr)
            {
                if (i == num) { output = 1; }
                
            }
            print:
                Console.Write(output);

        }
    }
}
