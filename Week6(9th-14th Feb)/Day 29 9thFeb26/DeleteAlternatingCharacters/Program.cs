namespace DeleteAlternatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str=Console.ReadLine();
            string str1 = "";//int k = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    str1 = str1 + str[i];
                }
            }
            Console.WriteLine(str1);
        }
    }
}
