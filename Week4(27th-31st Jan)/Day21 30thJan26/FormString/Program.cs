namespace FormString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp=0;
            Console.WriteLine("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            string[] input1 = new string[size];
            Console.WriteLine("Enter Elements: ");
            for(int i = 0; i < size; i++)
            {
                input1[i] = Console.ReadLine();
                foreach(char c in input1[i])
                {
                    if (Char.IsSymbol(c)){  temp = -1; }
                }
            }
            //Console.WriteLine(temp);
            if (temp == -1) { Console.WriteLine(temp);return; }

            Console.Write("Enter character num: ");
            int input2=int.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.formString(input1, input2));
        }
    }
}
