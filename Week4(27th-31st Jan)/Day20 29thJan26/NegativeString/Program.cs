namespace NegativeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string res=UserProgramCode.NegativeStr(str);
            Console.WriteLine(res);
            
        }
    }
}
