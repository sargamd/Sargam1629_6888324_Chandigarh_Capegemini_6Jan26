using CompanyEmployees_1toMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees_1toMany.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ApplicationdbContext _context;

        public CompaniesController(ApplicationdbContext context)
        {
            _context = context;
        }

        // SHOW COMPANIES + EMPLOYEES
        public IActionResult Index()
        {
            var companies = _context.Company
                .Include(c => c.Employees)
                .ToList();

            return View(companies);
        }

        // GET CREATE COMPANY
        public IActionResult Create()
        {
            return View();
        }

        // POST CREATE COMPANY
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Company.Add(company);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(company);
        }
    }
}
