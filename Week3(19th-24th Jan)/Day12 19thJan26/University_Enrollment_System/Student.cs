using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment_System
{
    internal class Student:Person
    {
        public string course;

        public Student(int id, string name, string email, string course)
            : base(id, name, email)
        {
            this.course = course;
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine("Enrolled Course: " + course);
        }
    }
}
