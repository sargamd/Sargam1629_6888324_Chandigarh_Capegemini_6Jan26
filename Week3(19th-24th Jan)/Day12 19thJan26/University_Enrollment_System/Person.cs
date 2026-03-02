using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment_System
{
    internal class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email;

        public Person(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        //public int Id { get { return id; } }
        //public string Name { get { return name; } }

        public virtual void DisplayProfile()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
        }
    }
}
