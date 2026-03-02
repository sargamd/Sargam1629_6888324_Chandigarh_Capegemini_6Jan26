namespace Bank_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int ch;
            //while (true)
            //{
            //    Console.WriteLine("1. Create Bank Account(Savings/Checking)");
            //    Console.WriteLine("2. Display Details");
            //    Console.WriteLine("3. Deposit Money");
            //    Console.WriteLine("4. Withdraw Money");
            //    Console.WriteLine("5. Calculate Interest");
            //    Console.WriteLine("6. Exit");
            //    Console.Write("ENter choice: ");
            //    ch = int.Parse(Console.ReadLine());
            //    if (ch == 6) { return; }
            //    switch (ch)
            //    {
            //        case 1:
            //            Console.Write("Enter type: ");
            //            string type = Console.ReadLine();

            //            if (type == "saving") { SavingAccount acc1 = new SavingAccount(); }
            //            else if (type == "checking") { CheckingAccount acc1 = new CheckingAccount(); }
            //            else { Console.WriteLine("Invalid type"); }
            //            break;
            //        case 2:
            //            acc1.Display();
            //            break;
            //    }
            //}
            Console.WriteLine("Account Creation");
            Console.WriteLine("Savings Account");
            SavingAccount acc1 = new SavingAccount();
            acc1.Deposit(5000);
            acc1.Deposit(500);
            acc1.Display();

            Console.WriteLine("Yearly Interest: " + acc1.calculateInterest());

            Console.WriteLine("Checking Account");
            CheckingAccount acc2= new CheckingAccount();
            acc2.Deposit(1000);
            acc2.Withdraw(10000);
            acc2.Display();
            Console.WriteLine("Yearly Interest: " + acc2.calculateInterest());






        }
    }
}
