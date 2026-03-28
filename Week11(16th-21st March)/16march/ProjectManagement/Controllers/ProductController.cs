using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Filters;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    public class ProductController : Controller
    {
        private static bool throwError = true; // toggle for testing

        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult Index()
        {
            if (throwError)
            {
                throw new Exception("Test exception in Index action");
            }

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 80000 },
                new Product { Id = 2, Name = "Phone", Price = 30000 },
                new Product { Id = 3, Name = "Tablet", Price = 20000 }
            };

            return View(products);
        }


    }
}
