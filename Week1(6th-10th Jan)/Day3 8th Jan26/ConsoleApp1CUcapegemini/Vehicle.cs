using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class Vehicle
    {
        string type;
        string colour;
        int wheels;
        int storage;

        public void start()
        {
            Console.WriteLine("Vehile is Starting");
        }
        public void stop() { Console.WriteLine("Stop the Vehicle"); }
        public void engine() { Console.WriteLine("Vehicle engine"); }

        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            car.type = "Land";
            car.colour = "Red";
            //Console.WriteLine("Vehicle is ",car.type," type and of ",car.colour," colour");
            car.start();
            car.stop();
            car.engine();

        }
    }
}
