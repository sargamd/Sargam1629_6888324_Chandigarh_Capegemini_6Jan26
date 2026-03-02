using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment_System
{
    internal class Course
    {
        public string CourseName;
        public int Credits;

        public Course(string courseName, int credits)
        {
            CourseName = courseName;
            Credits = credits;
        }
    }
}
