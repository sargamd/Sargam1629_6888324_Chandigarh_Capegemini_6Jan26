using Microsoft.AspNetCore.Mvc;
using Student_Registration.Models;

namespace Student_Registration.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();

        // GET: Student/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Student/Register
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = students.Count + 1;
                students.Add(student);

                TempData["SuccessMessage"] = "Student Registered Successfully!";

                return RedirectToAction("Details", new { id = student.Id });
            }

            return View(student);
        }

        // GET: Student/Details/1
        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
