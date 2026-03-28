using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Filters;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();

        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult Index()
        {
            // TEST Exception
            // throw new Exception("Test Exception");

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var product = products.Find(p => p.Id == id);
            return View(product);
        }
    }
}
