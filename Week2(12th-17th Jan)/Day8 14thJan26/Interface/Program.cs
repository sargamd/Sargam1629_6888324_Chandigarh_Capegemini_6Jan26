namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassC obj = new ClassC();
            Interface1 i1 = (Interface1) obj;
            Interface2 i2 = obj;
            i1.f1();
            i2.f1();


        }
    }
}
