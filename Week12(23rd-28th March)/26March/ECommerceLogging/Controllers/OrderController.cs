using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ECommerceLogging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public IActionResult CreateOrder(int userId)
        {
            try
            {
                log.Info($"Order started for user {userId}");

                // simulate success
                log.Info("Order created successfully");

                return Ok("Order placed");
            }
            catch (Exception ex)
            {
                log.Error("Order failed", ex);
                return StatusCode(500);
            }
        }
    }
}
