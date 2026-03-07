using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    internal abstract class Employee
    {
        string department;
        string name;
        string location;
        bool isOnVacation = false;

        public Employee(string department, string name, string location)
        {
            this.department = department;
            this.name = name;
            this.location = location;
        }

        public string GetDepartment()
        {
            return department;
        }

        public string GetName()
        {
            return name;
        }

        public string GetLocation()
        {
            return location;
        }

        public bool GetStatus()
        {
            return isOnVacation;
        }

        public void SwitchStatus()
        {
            isOnVacation = !isOnVacation;
        }
    }
    class FinanceEmployee : Employee
    {
        public FinanceEmployee(string name, string location)
            : base("Finance", name, location)
        {
        }
    }

    class MarketingEmployee : Employee
    {
        public MarketingEmployee(string name, string location)
            : base("Marketing", name, location)
        {
        }
    }
}
