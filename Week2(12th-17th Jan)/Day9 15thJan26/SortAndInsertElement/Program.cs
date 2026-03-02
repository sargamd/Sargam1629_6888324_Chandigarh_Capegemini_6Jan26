namespace SortAndInsertElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size; int output = 0;
            Console.Write("Enter size of array: ");
            size = int.Parse(Console.ReadLine());
            if (size < 0) { output = -2; Console.Write(output); return; }
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0) { output = -1; }
            }
            if (output == -1) { Console.WriteLine(output); return; }
            Console.Write("Enter element: ");
            int num=int.Parse(Console.ReadLine());
            //Array.Sort(arr);
            ////Array.Resize(ref arr, size+1);
            //int k = 0;
            //int[] arr2=new int[size+1];
            //for(int i = 0; i < arr.Length; i++)
            //{
                
            //    if(arr[i] < num)
            //    {
            //        arr2[k] = arr[i];
            //        k++;
            //    }
            //    if(!arr2.Contains(num))
            //    {
            //        arr2[k] = num;
            //        k++;
            //    }
            //    //else
            //    //{
            //    //    arr2[k] = arr[i];
            //    //    k++;
            //    //}
            //}
            Array.Resize(ref arr, size+1);
            arr[size] = num;
            Array.Sort(arr);
            
            foreach(int i in arr) {  Console.Write(i+" "); }
            

        }
    }
}
