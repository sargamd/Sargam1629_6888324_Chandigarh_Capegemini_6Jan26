namespace AnagramCheck
{
    internal class Program
    {
        public static bool Anagramchk(string str1, string str2)
        {           
            bool ans=false;
            char[] r= str1.ToCharArray();
            char[] c= str2.ToCharArray();
            //str1.ToCharArray();
            Array.Sort(r);
            //Console.WriteLine(r);
            Array.Sort(c);
            //Console.WriteLine(c);
            for(int i = 0; i < r.Length; i++)
            {
                if (r[i] == c[i])
                {
                    ans=true;

                }
                else
                {
                    ans=false;
                }
            }
            return ans;
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter string: ");
            string str1=Console.ReadLine();
            Console.Write("Enter string: ");
            string str2=Console.ReadLine();
            Console.WriteLine(Anagramchk(str1, str2));
        }
    }
}
