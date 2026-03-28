using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
namespace EmployeePortal.Filters
{
    public class LogActionFilter:IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.Session.GetString("Username") ?? "Guest";

            Console.WriteLine($"[LOG] User: {user} | Action: {context.ActionDescriptor.DisplayName} | Time: {DateTime.Now}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"[LOG] Completed at {DateTime.Now}");
        }
    }
}
