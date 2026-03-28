using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ECommerceLogging.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost("login")]
        public IActionResult Login(string email, string password)
        {
            try
            {
                log.Info($"Login attempt: {email}");

                if (password != "123")
                {
                    log.Warn("Invalid password");
                    return Unauthorized("Invalid credentials");
                }

                return Ok("Login successful");
            }
            catch (Exception ex)
            {
                log.Error("Login error", ex);
                return StatusCode(500);
            }
        }
    }
}
