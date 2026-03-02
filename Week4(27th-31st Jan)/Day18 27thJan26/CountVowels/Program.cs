namespace CountVowels
{
    internal class Program
    {
        public static int Countvowels(string n)
        {
            int count = 0;
            n.ToLower();
            for(int i = 0; i < n.Length; i++)
            {
                if(n[i]=='a'|| n[i] == 'e' || n[i] == 'i' || n[i] == 'o' || n[i] == 'u')
                {
                    count++;
                }
            }
            return count;
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter string: ");
            string str=Console.ReadLine();
            Console.WriteLine(Countvowels(str));
            
        }
    }
}
