namespace MaxFrequencyElements
{
    internal class Program
    {
        public static int MaxFrequrncy(int[] nums)
        {
            Array.Sort(nums);
            int max = nums[nums.Length - 1];
            int[] arr= new int[max+1];
            for(int i = 0; i < nums.Length; i++)
            {
                arr[nums[i]]++;
            }
            max=arr[0];int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) { max=arr[i]; }
            }
            for(int i=0;i<arr.Length; i++)
            {
                if (max == arr[i])
                {
                    count=count+arr[i];
                }
            }
            return count;
        }
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
            Console.WriteLine(MaxFrequrncy(arr));
            
            
        

        }
    }
}
