using StudentPortal_Middleware.Models;
using StudentPortal_Middleware.Services;
using System.Diagnostics;

namespace StudentPortal_Middleware.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IRequestLogService logService)
        {
            var stopwatch = Stopwatch.StartNew();

            await _next(context);

            stopwatch.Stop();

            logService.AddLog(new RequestLog
            {
                Url = context.Request.Path,
                ExecutionTime = stopwatch.ElapsedMilliseconds
            });
        }
    }
}
