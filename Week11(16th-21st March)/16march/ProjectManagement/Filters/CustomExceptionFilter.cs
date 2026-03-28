using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjectManagement.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Console.WriteLine($"[ERROR] {context.Exception.Message}");

            context.Result = new ViewResult
            {
                ViewName = "Error"
            };

            context.ExceptionHandled = true;
        }
    }
}
