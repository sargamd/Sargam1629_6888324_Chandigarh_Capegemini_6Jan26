namespace FarenheitToCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in farenheit: ");
            double f;double c;
            f=double.Parse(Console.ReadLine());
            if (f < 0) { c = -1;goto print; }
            c = (f - 32)/1.8;
            print:
                Console.Write(c);
        }
    }
}
