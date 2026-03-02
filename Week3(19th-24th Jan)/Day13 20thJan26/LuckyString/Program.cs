namespace LuckyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ENter string: ");
            string str = Console.ReadLine();
            Stringlucky obj=new Stringlucky();

            Console.WriteLine(obj.Checkstring(n, str));
        }
    }
}
