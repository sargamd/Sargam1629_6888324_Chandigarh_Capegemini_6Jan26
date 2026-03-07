using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInheritance
{

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    abstract class User
    {
        string type;
        string name;
        Gender gender;
        int age;

        public User(string type, string name, Gender gender, int age)
        {
            this.type = type;
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public string GetUserName()
        {
            return name;
        }

        public string GetUserType()
        {
            return type;
        }

        public int GetAge()
        {
            return age;
        }

        public Gender GetGender()
        {
            return gender;
        }
    }

    class Admin : User
    {
        public Admin(string name, Gender gender, int age)
            : base("Admin", name, gender, age)
        {
        }
    }

    class Moderator : User
    {
        public Moderator(string name, Gender gender, int age)
            : base("Moderator", name, gender, age)
        {
        }
    }
}
