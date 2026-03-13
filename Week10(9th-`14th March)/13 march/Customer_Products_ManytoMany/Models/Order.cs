using System.ComponentModel.DataAnnotations;

namespace Customer_Products_ManytoMany.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        // Navigation Properties
        public Customer Customer { get; set; }

        public Product Product { get; set; }
    }
}
