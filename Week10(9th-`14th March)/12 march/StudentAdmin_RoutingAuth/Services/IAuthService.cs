namespace StudentAdmin_RoutingAuth.Services
{
    public interface IAuthService
    {
        bool ValidateUser(string username, string password);
        bool IsAuthenticated(HttpContext context);
    }
}
