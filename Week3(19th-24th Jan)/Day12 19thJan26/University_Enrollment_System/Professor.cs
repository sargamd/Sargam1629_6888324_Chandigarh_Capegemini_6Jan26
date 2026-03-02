using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace University_Enrollment_System
{
    internal class Professor:Person
    {
        public string subject;

        public Professor(int id, string name, string email, string subject)
            : base(id, name, email)
        {
            this.subject = subject;
        }

        public void AssignCourse(string courseName)
        {
            Console.WriteLine(courseName + " assigned to Professor " + name);
        }
    }
}
