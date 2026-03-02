namespace Replace1st_lastElementArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size; int r1 = 0;
            Console.Write("Enter size: ");
            size = int.Parse(Console.ReadLine());
            if (size < 0) { r1 = -2; Console.Write(r1); return; }
            
            int[] arr1 = new int[size];
            Console.Write("Enter Array elements: ");
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                if (arr1[i] < 0) { r1 = 1; }
            }
            int[] arr2 = new int[size];
            int j = 0, k = size - 1;
            while (j < size)
            {
                //if (j == k) { j++;k--;continue; }
                arr2[j] = arr1[k];
                j++; k--;

            }
            
            if (size % 2 == 0)
            {
                Array.Resize(ref arr2, size + 1);

                for (int i = size - 1; i >= 0; i--)
                {
                    arr2[i + 1] = arr2[i];
                }
                arr2[0] = -3;
                foreach (int x in arr2) { Console.Write(x + "  "); }
                Console.WriteLine();
                
            }
            else if (r1 == 1)
            {
                Array.Resize(ref arr2, size + 1);

                for (int i = size - 1; i >= 0; i--)
                {
                    arr2[i + 1] = arr2[i];
                }
                arr2[0] = -1;
                foreach (int x in arr2) { Console.Write(x + "  "); }
                Console.WriteLine();
            }
            else
            {
                foreach (int x in arr2) { Console.Write(x + "  "); }
            }


        }
    }
}
