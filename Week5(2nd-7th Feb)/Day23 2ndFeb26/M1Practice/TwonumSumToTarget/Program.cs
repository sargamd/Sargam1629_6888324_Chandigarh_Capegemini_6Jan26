namespace TwonumSumToTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            int[] arr=new int[size];
            Console.WriteLine("Enter elements: ");
            for(int i = 0; i < size; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.Write("Enter target: ");
            int target=int.Parse(Console.ReadLine());
            for(int i = 0;i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == target)
                    {
                        Console.Write(i+" "+j);
                    }
                }
            }
        }
    }
}
