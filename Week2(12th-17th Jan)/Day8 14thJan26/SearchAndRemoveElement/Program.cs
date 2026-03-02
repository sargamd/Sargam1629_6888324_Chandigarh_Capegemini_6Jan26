namespace SearchAndRemoveElement
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
            int[] arr2 = new int[size];
            foreach (int i in arr) { if (i < 0) { output = -1; Console.Write(output); return; } }
            Console.Write("Element to be searched: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            foreach(int i  in arr)
            {
                output = 0;
                if (i == num) { break; }
                else { output = -1; }
            }
            
            for(int i=0;i< size; i++)
            {
                if (arr[i] == num)
                {
                    continue;
                    
                }
                else
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }
            if (output == -1) { Console.Write(output); return; }
            Array.Resize(ref arr2, size-1);
            foreach(int i in arr2) {  Console.Write(i+" "); }
        }
    }
}
