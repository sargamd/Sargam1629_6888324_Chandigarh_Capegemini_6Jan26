namespace ListElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size: ");
            int n=int.Parse(Console.ReadLine());
            List<int> input1 = new List<int>();
            Console.WriteLine("Enter elements: ");
            for(int i = 0; i < n; i++)
            {
                int x=int.Parse(Console.ReadLine());
                input1.Add(x);
            }
            //if (input1.Count == 0) { goto print; }
            Console.Write("Enter integer: ");
            int input2=int.Parse(Console.ReadLine());
            
            List<int> result= new List<int>();
            result=UserProgramCode.getElements(input1,input2);
            if (result.Count == 0) { Console.WriteLine("No element found"); }
            else
            {
                foreach (int i in result) { Console.Write(i + " "); }                
            }
            



        }
    }
}
