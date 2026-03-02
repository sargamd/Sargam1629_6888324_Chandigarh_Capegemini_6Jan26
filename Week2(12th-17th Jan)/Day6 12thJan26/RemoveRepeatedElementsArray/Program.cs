namespace RemoveRepeatedElementsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size; int output;
            Console.Write("Enter size: ");
            size = int.Parse(Console.ReadLine());
            if (size < 0) { output = -2; Console.Write(output); }
            int[] arr = new int[size];
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    result[0] = -1;
                    foreach (int k in result) { Console.Write(k + " "); }
                    return;
                }
            }

            int max = arr[0];
            foreach (int i in arr)
            {
                if (max < i) { max = i; }
            }
            int[] newarr = new int[max + 1];
            foreach (int i in arr)
            {
                newarr[i]++;
            }
            int it = 0;
            for (int k = 0; k < newarr.Length; k++)
            {
                if (newarr[k] != 0)
                {
                    result[it] = k;
                    it++;
                }
            }
            Array.Resize(ref result, it);
            foreach (int i in result) { Console.Write(i + " "); }
        }
    }
}
