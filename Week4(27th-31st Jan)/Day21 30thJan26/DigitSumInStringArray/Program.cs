namespace DigitSumInStringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size: ");
            int size=int.Parse(Console.ReadLine());
            string[] input1=new string[size];
            Console.WriteLine("Enter elements: ");
            for(int i=0; i<input1.Length; i++)
            {
                input1[i] = Console.ReadLine();
            }
            Console.WriteLine(UserProgramCode.sumOfDigits(input1));

        }
    }
}
