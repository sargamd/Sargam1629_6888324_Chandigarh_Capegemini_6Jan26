using System.Transactions;

namespace RotateArrayRight
{
    internal class Program
    {
        public static int[] RotateArray(int[] nums,int k)
        {
            int[] arr=new int[nums.Length];int j = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (i + k < nums.Length) { arr[i + k] = nums[i]; }
                else
                {
                    if (j < k) { arr[j] = nums[i]; j++; }                   
                }
                    
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            int[] nums=new int[size];
            Console.WriteLine("Enter elements: ");
            for(int i=0; i < size; i++) { nums[i]=int.Parse(Console.ReadLine()); }
            Console.Write("ENter k: ");
            int k = int.Parse(Console.ReadLine());
            int[] r=RotateArray(nums,k);
            foreach(int  i in r) {  Console.Write(i+" "); }

        }
    }
}
