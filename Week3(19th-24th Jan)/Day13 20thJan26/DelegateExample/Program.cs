namespace DelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiclass obj=new Multiclass();
            Math m = new Math(obj.Add);
            m += obj.Sub;
            m += obj.Multiply;
            m += obj.Div;
            m(100, 50);
            Console.WriteLine();
            m(625, 25);
            Console.WriteLine();
            m -=obj.Div;
            m(2, 3);
            Console.WriteLine();
        }
    }
}
