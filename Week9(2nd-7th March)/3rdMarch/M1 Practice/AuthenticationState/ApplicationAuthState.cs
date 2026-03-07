using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationState
{
    internal class ApplicationAuthState
    {
        public List<string> AllowedLocations { get; set; }
        public List<User> RegisteredUsers { get; set; }
        public List<User> UsersLoggedIn { get; set; }

        public ApplicationAuthState(List<string> locations)
        {
            AllowedLocations = locations;
            RegisteredUsers = new List<User>();
            UsersLoggedIn = new List<User>();
        }

        public string Register(User user)
        {
            if (RegisteredUsers.Any(x => x.Email == user.Email))
                return $"{user.Email} is already registered!";

            RegisteredUsers.Add(user);
            return $"{user.Email} registered successfully!";
        }

        public string Login(User user)
        {
            var regUser = RegisteredUsers.FirstOrDefault(x => x.Email == user.Email);

            if (regUser == null)
                return $"{user.Email} is not registered!";

            if (regUser.IncorrectAttempt >= 3)
                return $"{user.Email} is blocked!";

            if (!AllowedLocations.Contains(user.Location))
                return $"{user.Email} is not allowed to login from this location!";

            var loggedUser = UsersLoggedIn.FirstOrDefault(x => x.Email == user.Email);

            if (loggedUser != null)
            {
                if (loggedUser.Location == user.Location)
                    return $"{user.Email} is already logged in!";
                else
                    return $"{user.Email} is already logged in from another location!";
            }

            if (regUser.Password != user.Password)
            {
                regUser.IncorrectAttempt++;
                return $"{user.Email} password is incorrect!";
            }

            regUser.IncorrectAttempt = 0;
            UsersLoggedIn.Add(regUser);
            return $"{user.Email} logged in successfully!";
        }

        public string Logout(User user)
        {
            var loggedUser = UsersLoggedIn.FirstOrDefault(x => x.Email == user.Email);

            if (loggedUser == null)
                return $"{user.Email} is not logged in!";

            UsersLoggedIn.Remove(loggedUser);
            return $"{user.Email} logged out successfully!";
        }
    }
}
