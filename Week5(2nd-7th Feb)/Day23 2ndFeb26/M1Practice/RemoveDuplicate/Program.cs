namespace RemoveDuplicate
{
    internal class Program
    {
        public static int RemoveDuplicate(int[] nums)
        {
            int max = nums[nums.Length - 1];
            int[] arr=new int[max+1];
            for(int i = 0; i < nums.Length; i++)
            {
                arr[nums[i]]++;
            }
            int k = 0;
            foreach(int i in arr)
            {
                if (i != 0) { k++; }
            }
            return k;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            //int wed = size;
            int[] nums=new int[size];
            for(int i = 0; i < size; i++)
            {
                nums[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(RemoveDuplicate(nums));
        }
    }
}
