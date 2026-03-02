namespace FirstNonRepeatingChar
{
    internal class Program
    {
        public static char FirstNonRepeatChar(string str)
        {
            str.ToCharArray();char ch = str[0];
            int[] word= new int[256];
            //word[0]='a';
            for(int i = 0; i < str.Length; i++)
            {
                word[str[i]]++;
            }
            foreach(char c in str)
            {
                if (word[c] == 1)
                {
                    ch = c;
                    break;
                }
            }
            return ch;
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter string: ");
            string str=Console.ReadLine();
            Console.WriteLine(FirstNonRepeatChar(str));
        }
    }
}
