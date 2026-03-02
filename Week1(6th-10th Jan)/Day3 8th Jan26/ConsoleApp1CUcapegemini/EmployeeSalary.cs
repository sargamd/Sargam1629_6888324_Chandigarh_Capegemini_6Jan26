using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1CUcapegemini
{
    internal class EmployeeSalary
    {
        int EmpId;
        string EmpName;
        string EmpDepartment;
        float basic, hra, da;

        public void getDetails()
        {
            Console.Write("Enter EmpId: ");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            this.EmpName = Console.ReadLine();
            Console.Write("Enter Department: ");
            this.EmpDepartment = Console.ReadLine();
            Console.Write("Enter Basic Salary: ");
            this.basic = float.Parse(Console.ReadLine());
            Console.Write("Enter HRA & DA: ");
            this.hra= float.Parse(Console.ReadLine());
            this.da= float.Parse(Console.ReadLine());
        }

        public float calculate()
        {
            float total = this.basic + this.hra + this.da;
            return total;
        }

        public void displaydetails()
        {
            Console.WriteLine("Employee id is " + this.EmpId);
            Console.WriteLine("Employee Name: " + this.EmpName);
            Console.WriteLine("Department: " + this.EmpDepartment);
            Console.WriteLine("Total Salary: " + calculate());
        }

        static void Main(string[] args)
        {
            EmployeeSalary emp1 = new EmployeeSalary();
            Console.WriteLine("Enter details");
            emp1.getDetails();
            Console.WriteLine("Details with total Salary: ");
            emp1.displaydetails();

        }

    }
}
