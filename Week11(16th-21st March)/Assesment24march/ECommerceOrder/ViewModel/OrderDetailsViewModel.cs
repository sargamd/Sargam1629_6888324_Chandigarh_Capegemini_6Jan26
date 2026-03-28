using ECommerceOrder.Models;

namespace ECommerceOrder.ViewModel
{
    public class OrderDetailsViewModel
    {
        public Order Order { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public ShippingDetail ShippingDetail { get; set; }
    }
}
