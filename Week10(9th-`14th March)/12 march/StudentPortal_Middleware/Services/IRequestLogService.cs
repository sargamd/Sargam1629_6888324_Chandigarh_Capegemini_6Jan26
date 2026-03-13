using StudentPortal_Middleware.Models;

namespace StudentPortal_Middleware.Services
{
    public interface IRequestLogService
    {
        void AddLog(RequestLog log);
        List<RequestLog> GetLogs();
    }
}
