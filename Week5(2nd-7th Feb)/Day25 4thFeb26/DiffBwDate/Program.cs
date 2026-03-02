namespace DiffBwDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Start Date : ");
            string input1 = Console.ReadLine(); 
            Console.Write("Enter End Date : ");
            string input2 = Console.ReadLine(); 

            DateTime date1 = DateTime.ParseExact(input1, "dd/MM/yyyy", null);
            DateTime date2 = DateTime.ParseExact(input2, "dd/MM/yyyy", null);

            int days = (date2 - date1).Days;

            Console.WriteLine(days + " days");
        }
    }
}
