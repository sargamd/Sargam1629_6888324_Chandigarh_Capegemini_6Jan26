namespace Donation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENter size: ");
            int size=int.Parse(Console.ReadLine());
            string[] input1 = new string[size];
            Console.WriteLine("Enter codes: ");
            for(int i=0;i<input1.Length; i++)
            {
                input1[i] = Console.ReadLine();
                if (input1[i].Length != 9)
                {
                    Console.Write("Invalid code");
                    return;
                }
            }
            Console.Write("Enter location code: ");
            int input2=int.Parse(Console.ReadLine());
            if (input2 < 100 || input2 > 999)
            {
                Console.WriteLine("Invalid code");
                return;
            }
            //UserProgramCode cd = new UserProgramCode();
            Console.WriteLine("Donation sum: "+UserProgramCode.getDonation(input1,input2));
           
        }
    }
}
