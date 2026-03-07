namespace AuthenticationState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> locations = new List<string>();

            for (int i = 0; i < n; i++)
                locations.Add(Console.ReadLine());

            ApplicationAuthState app = new ApplicationAuthState(locations);

            int m = int.Parse(Console.ReadLine());
            List<User> users = new List<User>();

            for (int i = 0; i < m; i++)
            {
                var data = Console.ReadLine().Split(',');
                users.Add(new User(
                    int.Parse(data[0]),
                    data[1],
                    data[2],
                    data[3]
                ));
            }

            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                var op = Console.ReadLine().Split(':');

                string action = op[0];
                int index = int.Parse(op[1]);

                if (action == "Register")
                    Console.WriteLine(app.Register(users[index]));

                else if (action == "Login")
                    Console.WriteLine(app.Login(users[index]));

                else if (action == "Logout")
                    Console.WriteLine(app.Logout(users[index]));
            }
        }
    }
}
