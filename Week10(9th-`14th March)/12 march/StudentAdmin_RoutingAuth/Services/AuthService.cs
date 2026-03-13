namespace StudentAdmin_RoutingAuth.Services
{
    public class AuthService:IAuthService
    {
        private readonly string adminUser = "admin";
        private readonly string adminPass = "123";

        public bool ValidateUser(string username, string password)
        {
            return username == adminUser && password == adminPass;
        }

        public bool IsAuthenticated(HttpContext context)
        {
            return context.Session.GetString("User") != null;
        }
    }
}
