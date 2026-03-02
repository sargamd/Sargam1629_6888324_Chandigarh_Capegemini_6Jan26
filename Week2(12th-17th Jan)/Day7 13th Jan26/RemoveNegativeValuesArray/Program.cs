namespace RemoveNegativeValuesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter size: ");
            size=int.Parse(Console.ReadLine());
            if (size < 0) { int output = -1; Console.Write(output); return; }
            int[] arr=new int[size];
            for(int i=0; i<size; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int[] arr2=new int[size];int j = 0,k=0;
            while (j < size)
            {
                if (arr[j] > 0)
                {
                    arr2[k] = arr[j];
                    k++;
                }
                j++;
            }
            Array.Resize(ref arr2, k);
            Array.Sort(arr2);
            foreach (int i in arr2) { Console.Write(i+" "); }
        }
    }
}
