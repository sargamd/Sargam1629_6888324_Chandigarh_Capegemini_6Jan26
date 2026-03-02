namespace CountElements
{
    internal class Program
    {
        public static int GetCount(int size, string[] input1,char input2)
        {
            int count = 0;
            Char.ToLower(input2);
            foreach(var x in input1)
            {
                for(int i=0;i<x.Length; i++)
                {
                    if(!Char.IsLetter(x[i])){ return -2; }
                }
                
                string s=x.ToLower();
                
                if (s.StartsWith(input2))
                {
                    count++;
                }
            }
            if (count == 0) { return -1; }
            return count;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            string[] input1 = new string[size];
            Console.WriteLine("Enter Elements: ");
            for(int i=0;i<size; i++)
            {
                input1[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter alphabet: ");
            char input2=char.Parse(Console.ReadLine());
            int count=GetCount(size, input1,input2);
            if (count == -1) { Console.WriteLine("No elements found"); }
            else if (count == -2) { Console.WriteLine("Only alphabets should be given"); }
            else
            {
                Console.WriteLine(count);
            }


        }
    }
}
