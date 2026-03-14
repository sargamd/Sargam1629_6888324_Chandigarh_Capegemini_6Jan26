using EmployeeProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProject.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly CompanyContext _context;

        public ProjectsController(CompanyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Projects.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Employees = _context.Employees.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project, List<int> employeeIds)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();

            foreach (var emp in employeeIds)
            {
                _context.EmployeeProjects.Add(new Employee_Project
                {
                    EmployeeId = emp,
                    ProjectId = project.ProjectId,
                    AssignedDate = DateTime.Now
                });
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        
        public IActionResult EmployeesInProject(int id)
        {
            var employees = _context.EmployeeProjects
                .Where(ep => ep.ProjectId == id)
                .Select(ep => ep.Employee)
                .ToList();

            return View(employees);
        }
    }
}
