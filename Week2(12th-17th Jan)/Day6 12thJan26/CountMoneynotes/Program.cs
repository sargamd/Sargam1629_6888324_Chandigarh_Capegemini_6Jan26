namespace CountMoneynotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;int notes = 0;
            Console.Write("Enter money: ");
            money=int.Parse(Console.ReadLine());
            notes = money / 500;
            money = money - notes * 500;
            notes = notes+notes / 100;
            money = money - notes;
        }
    }
}
