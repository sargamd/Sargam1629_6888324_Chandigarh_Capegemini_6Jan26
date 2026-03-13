using Microsoft.AspNetCore.Mvc;
using StudentAdmin_RoutingAuth.Models;
using StudentAdmin_RoutingAuth.Services;
using System.Diagnostics;

namespace StudentAdmin_RoutingAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthService _authService;

        public HomeController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (_authService.ValidateUser(username, password))
            {
                HttpContext.Session.SetString("User", username);

                return RedirectToAction("Dashboard", "Admin");
            }

            ViewBag.Error = "Invalid Credentials";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
