namespace Mathoperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENter number: ");
            int n = int.Parse(Console.ReadLine());
            Minoperation obj=new Minoperation();

            int result = obj.Minsteps(n);

            Console.WriteLine(result);
        }
    }
}
