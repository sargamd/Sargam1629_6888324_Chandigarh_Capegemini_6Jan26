using EmployeePortal.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    public class HRController : Controller
    {
        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult Index()
        {
            return View();
        }

        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult EmployeeList()
        {
            var list = EmployeeController.GetEmployees();
            return View(list);
        }

        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult Reports()
        {
            
            //throw new Exception("Report generation failed!");

            return View();
        }
    }
}
