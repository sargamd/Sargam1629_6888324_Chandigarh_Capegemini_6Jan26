namespace AddFirst_LastElementsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of Arrays to be taken: "); int temp;
            int size = int.Parse(Console.ReadLine());
            if (size < 0) { temp = -2; Console.Write(temp); return; }
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            int[] output = new int[size];
            int count = 0;
            Console.WriteLine("Enter elements 1st array: ");
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    count = 1;
                }
            }
            Console.WriteLine("Enter elements 2nd array: ");
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
                if (arr2[i] < 0)
                {
                    count = 1;
                }
            }
            int j = 0, k = size - 1, l = 0;
            while (j < size)
            {
                output[l] = arr1[j] + arr2[k];
                j++; k--; l++;
            }
            if (count == 1) { goto negative; }
            Console.Write("Output: ");
            foreach (int x in output) { Console.Write(x + "  "); }
            return;
        negative:
            Array.Resize(ref output, size + 1);
            
            for (int i = size-1; i>=0; i--)
            {
                output[i+1]=output[i];
            }
            output[0] = -1;
            foreach (int x in output) { Console.Write(x + "  "); }
        }
    }
}
