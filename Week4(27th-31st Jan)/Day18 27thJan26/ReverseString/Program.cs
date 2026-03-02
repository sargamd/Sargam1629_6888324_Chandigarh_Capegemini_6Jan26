namespace ReverseString
{
    internal class Program
    {
        public static string ReverseStr(string str)
        {
            //char[] rev=new char[str.Length];
            string rev="";
            
            str.ToCharArray();
            int n=str.Length-1;
            while(n>=0)
            {
                rev = rev+str[n];
                n--;
            }
            
            return rev;            
        }
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(ReverseStr(str));
            
        }
    }
}
