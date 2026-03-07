using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationState
{
    internal class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public int IncorrectAttempt { get; set; }

        public User(int id, string email, string password, string location)
        {
            Id = id;
            Email = email;
            Password = password;
            Location = location;
            IncorrectAttempt = 0;
        }
    }
}
