using Microsoft.AspNetCore.Mvc;

namespace StudentAdmin_RoutingAuth.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<string>
            {
                "Rahul",
                "Priya",
                "Amit"
            };

            return View(students);
        }
    }
}
