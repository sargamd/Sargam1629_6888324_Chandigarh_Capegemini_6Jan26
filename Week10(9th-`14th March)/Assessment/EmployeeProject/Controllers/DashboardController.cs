using EmployeeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly CompanyContext _context;

        public DashboardController(CompanyContext context)
        {
            _context = context;
        }

        
        public IActionResult ProjectDashboard()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }

        
        public IActionResult ProjectEmployees(int id)
        {
            var employees = _context.EmployeeProjects
                .Where(ep => ep.ProjectId == id)
                .Include(ep => ep.Employee)
                .ThenInclude(e => e.Department)
                .Select(ep => ep.Employee)
                .ToList();

            ViewBag.ProjectName = _context.Projects
                .Where(p => p.ProjectId == id)
                .Select(p => p.Title)
                .FirstOrDefault();

            return View(employees);
        }
    }
}
