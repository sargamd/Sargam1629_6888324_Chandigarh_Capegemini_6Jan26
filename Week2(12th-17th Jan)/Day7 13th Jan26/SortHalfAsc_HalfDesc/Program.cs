namespace SortHalfAsc_HalfDesc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter size: ");
            size=int.Parse(Console.ReadLine());
            if (size < 0) { int res = -1;Console.Write(res); return; }
            int[] arr=new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Entered Array: ");
            foreach (int i in arr) { Console.Write(i + " "); }
            int[] arr2=new int[size];
            int[] arr3=new int[size];
            Array.Copy(arr,arr2,size);
            //foreach (int i in arr2) { Console.Write(i + " "); }
            Array.Resize(ref arr,size/2);
            Array.Sort(arr);
            //foreach(int i  in arr) {  Console.Write(i+" "); }
            int k = 0;
            for(int i = size-1; i>=size/2; i--)
            {
                arr3[k] = arr2[i];
                k++;
            }
            if (size % 2 != 0) { Array.Resize(ref arr3, size / 2 + 1); }
            else { Array.Resize(ref arr3, size / 2); }
            Array.Sort(arr3);
            Array.Reverse(arr3);
            Console.WriteLine();
            //foreach (int i in arr3) { Console.Write(i + " "); }
            int[] output = new int[size];
            k = 0; int j = 0, m = 0;
            while (j < size)
            {
                if (k <arr.Length)
                {
                    output[j] = arr[k];
                    j++; k++;
                }
                else
                {
                    
                    output[j] = arr3[m];
                    j++; m++;   
                }

            }
            //Console.WriteLine();
            foreach (int i in output) { Console.Write(i + " "); }
            



        }
    }
}
