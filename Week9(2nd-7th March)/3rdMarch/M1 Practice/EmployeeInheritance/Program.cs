namespace EmployeeInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var financeInput = Console.ReadLine().Split();
            var marketingInput = Console.ReadLine().Split();

            FinanceEmployee finance = new FinanceEmployee(financeInput[0], financeInput[1]);
            MarketingEmployee marketing = new MarketingEmployee(marketingInput[0], marketingInput[1]);

            Console.WriteLine($"Finance Employee info: Department {finance.GetDepartment()}, Name {finance.GetName()}, Location {finance.GetLocation()}");
            PrintStatus(finance);

            Console.WriteLine("Switching");
            finance.SwitchStatus();
            PrintStatus(finance);

            Console.WriteLine("Switching");
            finance.SwitchStatus();
            PrintStatus(finance);

            Console.WriteLine($"MarketingEmployee info: Department {marketing.GetDepartment()}, Name {marketing.GetName()}, Location {marketing.GetLocation()}");
            PrintStatus(marketing);

            Console.WriteLine("Switching");
            marketing.SwitchStatus();
            PrintStatus(marketing);
        }

        static void PrintStatus(Employee emp)
        {
            if (emp.GetStatus())
                Console.WriteLine($"{emp.GetName()} is on vacation");
            else
                Console.WriteLine($"{emp.GetName()} is not on vacation");
        }
    }
    
}
