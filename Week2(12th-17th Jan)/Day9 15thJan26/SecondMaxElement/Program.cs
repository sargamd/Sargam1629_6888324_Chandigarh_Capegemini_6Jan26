namespace SecondMaxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;int output=0;
            Console.Write("Enter size of array: ");
            size=int.Parse(Console.ReadLine());
            if (size < 0) { output = -2;Console.Write(output);return;}
            int[] arr=new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
                if (arr[i] < 0) { output = -1; }
            }
            if (output == -1) { Console.WriteLine(output);return; }
            Array.Sort(arr);
            output = arr[size - 2];
            Console.WriteLine("Second Max: "+output);
        }
    }
}
