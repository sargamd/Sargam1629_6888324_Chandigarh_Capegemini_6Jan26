namespace SearchingElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;int location=-1;
            Console.Write("Enter size: ");
            size=Convert.ToInt32(Console.ReadLine());
            if (size < 0) { location = -2; Console.Write(location); return; }
            int[] arr = new int[size];
            for(int i=0; i < size; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
                if (arr[i] < 0) { location = -1; Console.Write(location); return; }
            }
            Console.Write("Element to be searched: ");
            int num=Convert.ToInt32(Console.ReadLine());
            
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == num) { location = i+1; break; }
            }
            if (location == -1) { location = 1;Console.Write("Not found:  " + location); }
            else { Console.Write("Location: "+location); }
        }
    }
}
