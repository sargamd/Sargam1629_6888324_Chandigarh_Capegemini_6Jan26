namespace CleanseandInvert
{
    internal class Program
    {
        public static string CleanseAndInvert(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 6)
                return "";

            
            foreach (char ch in input)
            {
                if (!char.IsLetter(ch))
                    return "";
            }

            
            input = input.ToLower();

            string filtered = "";

            
            foreach (char ch in input)
            {
                if (((int)ch) % 2 != 0)
                {
                    filtered += ch;
                }
            }

            // Reverse the filtered string
            char[] arr = filtered.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            
            char[] result = reversed.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = Char.ToUpper(result[i]);
                }
            }

            return new string(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();

            string output = CleanseAndInvert(input);

            if (output == "")
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("The generated key is: " + output);
            }
        }
    }
}