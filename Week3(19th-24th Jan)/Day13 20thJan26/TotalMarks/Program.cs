namespace TotalMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            int y=int.Parse(Console.ReadLine());
            Console.Write("Enter n1: ");
            int n1=int.Parse(Console.ReadLine());
            Console.Write("Enter n2: ");
            int n2=int.Parse(Console.ReadLine());

            Console.Write("Enter marks obtained: ");
            int m=int.Parse(Console.ReadLine());

            TotalMarks obj = new TotalMarks();
            obj.Validmarks(x,y, n1, n2,m);
        }
    }
}
