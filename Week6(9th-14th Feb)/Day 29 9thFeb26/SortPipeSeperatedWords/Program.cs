namespace SortPipeSeperatedWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter | separated words: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            string[] words = input.Split('|', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(w => w.Trim())
                                  .ToArray();

            Array.Sort(words);
            string result = string.Join("|", words);
            Console.WriteLine("Sorted: " + result);
        }
    }
}
