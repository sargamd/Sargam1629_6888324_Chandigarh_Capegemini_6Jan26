using Microsoft.AspNetCore.Mvc;

namespace StudentAdmin_RoutingAuth.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
