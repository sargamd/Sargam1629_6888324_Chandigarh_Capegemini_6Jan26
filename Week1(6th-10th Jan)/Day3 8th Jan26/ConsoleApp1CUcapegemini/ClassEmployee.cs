using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class ClassEmployee
    {
        int empid;
        string empname;
        string empaddress;
        int empAge;

        public void getDetails()
        {
            Console.Write("Enter EmpId: ");
            this.empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            this.empname = Console.ReadLine();
            Console.Write("Enter Address: ");
            this.empaddress = Console.ReadLine();
            Console.Write("Enter Age: ");
            this.empAge=int.Parse(Console.ReadLine());
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine("Employee id is " + this.empid);
            Console.WriteLine("Employee Name: "+this.empname);
            Console.WriteLine("Adress: " + this.empaddress);
            Console.WriteLine("Age: "+this.empAge);
        }

        static void Main(string[] args)
        {
            ClassEmployee obj1=new ClassEmployee();
            ClassEmployee obj2=new ClassEmployee();
            Console.WriteLine("Enter Employee details: ");
            obj1.getDetails();
            Console.WriteLine("Given Details are: ");
            obj1.DisplayEmpDetails();
        }
    }
}
