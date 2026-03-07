namespace BankChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> inputs = new List<string>();

            for (int i = 0; i < n; i++)
            {
                inputs.Add(Console.ReadLine());
            }

            BankOperation opt = new BankOperation();

            foreach (var item in inputs)
            {
                Console.WriteLine(opt.ProcessOperation(item));
            }
        }
    }
}
