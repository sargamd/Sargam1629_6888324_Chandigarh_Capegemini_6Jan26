using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment_System
{
    internal class Staff:Person
    {
        public string department;

        public Staff(int id, string name, string email, string department)
            : base(id, name, email)
        {
            this.department = department;
        }
    }
}
