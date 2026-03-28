using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ECommerceLogging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public IActionResult ProcessPayment()
        {
            try
            {
                log.Info("Payment request started");

                var start = DateTime.Now;

                // simulate delay
                Thread.Sleep(6000);

                var duration = (DateTime.Now - start).TotalSeconds;

                if (duration > 5)
                {
                    log.Warn("Payment delay > 5 sec");
                }

                return Ok("Payment successful");
            }
            catch (Exception ex)
            {
                log.Error("Payment failed", ex);
                return StatusCode(500);
            }
        }
    }
}
