namespace MaxDiffArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output=0;
            Console.Write("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            if (size == 1 || size > 10) {Console.WriteLine(-3);return; }
            int[] arr=new int[size];
            Console.WriteLine("Enter elements: ");
            for(int i=0; i<size; i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
                if (i < 0) { output=-1; }
            }
            if (output == -1) { Console.WriteLine(output);return; }

            if (arr.Count() != arr.Distinct().Count()) { Console.WriteLine(-3); return; }
            
            Console.WriteLine(UserProgramCode.diffIntArray(arr));


            

        }
    }
}
