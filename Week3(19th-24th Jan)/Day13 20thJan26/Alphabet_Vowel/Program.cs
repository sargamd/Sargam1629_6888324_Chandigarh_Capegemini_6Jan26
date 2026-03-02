namespace Alphabet_Vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter word: ");
            string word2 = Console.ReadLine();
            StringVowels obj=new StringVowels();

            Console.WriteLine(obj.Stringprocess(word1,word2));
        }
    }
}
