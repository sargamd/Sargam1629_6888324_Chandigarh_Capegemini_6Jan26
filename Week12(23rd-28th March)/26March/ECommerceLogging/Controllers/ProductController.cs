using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ECommerceLogging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            log.Info($"Fetching product {id}");

            if (id != 1)
            {
                log.Warn("Product not found");
                return NotFound();
            }

            return Ok(new { Id = 1, Name = "Laptop" });
        }
    }
}