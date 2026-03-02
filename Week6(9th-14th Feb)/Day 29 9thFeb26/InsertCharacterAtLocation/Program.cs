namespace InsertCharacterAtLocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string str=Console.ReadLine();
            Console.Write("Enter character: ");
            char c=Char.Parse(Console.ReadLine());
            Console.Write("Enter Position: ");
            int pos=int.Parse(Console.ReadLine());
            string temp = "";
            for(int i = 0; i < pos-1; i++)
            {
                temp = temp + str[i];
            }
            //Console.WriteLine(temp);
            temp = temp + c;
            //Console.WriteLine(temp);
            string temp2 = "";
            for(int i = pos-1; i < str.Length; i++)
            {
                temp2 = temp2 + str[i];
            }
            //Console.WriteLine(temp2);
            Console.WriteLine(temp + temp2);
        }
    }
}
