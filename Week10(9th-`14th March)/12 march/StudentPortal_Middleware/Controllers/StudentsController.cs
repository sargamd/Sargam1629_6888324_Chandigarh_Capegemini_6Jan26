using Microsoft.AspNetCore.Mvc;
using StudentPortal_Middleware.Services;

namespace StudentPortal_Middleware.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IRequestLogService _logService;

        public StudentsController(IRequestLogService logService)
        {
            _logService = logService;
        }

        public IActionResult Index()
        {
            var students = new List<string>
            {
                "Rahul",
                "Priya",
                "Amit"
            };

            ViewBag.Logs = _logService.GetLogs();

            return View(students);
        }
    }
}
