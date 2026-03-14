using EmployeeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeProject.Controllers
{
    public class EmployeesController : Controller
    {
            private readonly CompanyContext _context;

            public EmployeesController(CompanyContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var employees = _context.Employees
                    .Include(e => e.Department)
                    .ToList();

                return View(employees);
            }

            public IActionResult Create()
            {
                ViewBag.Projects = _context.Projects.ToList();
                return View();
            }

            [HttpPost]
            public IActionResult Create(Employee employee, string DepartmentName, List<int> projectIds)
            {

                
                var dept = _context.Departments
                    .FirstOrDefault(d => d.Name == DepartmentName);

                
                if (dept == null)
                {
                    dept = new Department
                    {
                        Name = DepartmentName
                    };

                    _context.Departments.Add(dept);
                    _context.SaveChanges();
                }

                
                employee.DepartmentId = dept.DepartmentId;

                _context.Employees.Add(employee);
                _context.SaveChanges();


                
                foreach (var pid in projectIds)
                {
                    _context.EmployeeProjects.Add(new Employee_Project
                    {
                        EmployeeId = employee.EmployeeId,
                        ProjectId = pid,
                        AssignedDate = DateTime.Now
                    });
                }

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            
            public IActionResult ProjectsOfEmployee(int id)
            {
                var projects = _context.EmployeeProjects
                    .Where(ep => ep.EmployeeId == id)
                    .Select(ep => ep.Project)
                    .ToList();

                return View(projects);
            }
    }
}

