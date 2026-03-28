using ECommerceOrder.Models;

namespace ECommerceOrder.ViewModel
{
    public class DashboardViewModel
    {
        public List<Product> TopProducts { get; set; }
        public List<Order> PendingOrders { get; set; }
        public Dictionary<string, int> CustomerOrderSummary { get; set; }
    }
}
