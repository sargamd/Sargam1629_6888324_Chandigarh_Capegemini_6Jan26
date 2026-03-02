namespace EmployeeDesignation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            string[] input1=new string[size];
            Console.WriteLine("Enter the elements: ");
            for(int i=0; i<size; i++)
            {
                input1[i] = Console.ReadLine();
            }
            //for(int i=0; i < size; i++)
            //{
            //    foreach (char c in input1[i])
            //    {
            //        if (Char.IsSymbol(c)) { Console.WriteLine("Invalid Input");return; }
            //    }
            //}
            
            Console.Write("Enter departement: ");
            string input2=Console.ReadLine();
            string[] res = new string[size];
            res=UserProgramCode.getEmployee(input1, input2);
            if (res == null) { Console.WriteLine("No employee for " + input2 + " designation"); }
            foreach(string s in res) { Console.Write(s+" "); }
            
        }
    }
}
