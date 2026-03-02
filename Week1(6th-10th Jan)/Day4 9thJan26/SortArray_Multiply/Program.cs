namespace SortArray_Multiply
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
            Console.WriteLine("Enter elements 1st array: ");
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    output[0] = -1;
                    foreach (int x in output) { Console.Write(x + "  "); }
                    return;
                }
            }
            Console.WriteLine("Enter elements 2nd array: ");
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
                if (arr2[i] < 0)
                {
                    output[0] = -1;
                    foreach (int x in output) { Console.Write(x + "  "); }
                    return;
                }
            }
            Array.Sort(arr1); //foreach (int x in arr1) { Console.Write(x + "  "); }
            Array.Sort(arr2); Array.Reverse(arr2); //foreach (int x in arr2) { Console.Write(x + "  "); }
            int j = 0, k = size - 1,l=0;
            while (j < size)
            {
                output[l] = arr1[j] * arr2[k];
                j++;k--;l++;
            }
            Console.Write("Output: ");
            foreach(int x in output) { Console.Write(x + "  "); }
        }
    }
}
