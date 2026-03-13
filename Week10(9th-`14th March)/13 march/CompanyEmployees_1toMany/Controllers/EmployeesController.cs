using CompanyEmployees_1toMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CompanyEmployees_1toMany.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationdbContext _context;

        public EmployeesController(ApplicationdbContext context)
        {
            _context = context;
        }

        // GET ADD EMPLOYEE
        public IActionResult Create()
        {
            ViewBag.CompanyList = new SelectList(_context.Company, "CompanyId", "Name");
            return View();
        }

        // POST ADD EMPLOYEE
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();

                return RedirectToAction("Index", "Companies");
            }

            return View(employee);
        }
    }
}
