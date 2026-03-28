using EmployeePortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>();

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee emp)
        {
            if (ModelState.IsValid)
            {
                employees.Add(emp);

                TempData["Success"] = "Employee Registered Successfully!";
                return RedirectToAction("Details", emp);
            }

            return View(emp);
        }

        public IActionResult Details(Employee emp)
        {
            return View(emp);
        }

        public static List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
