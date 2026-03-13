using System.ComponentModel.DataAnnotations;

namespace Customer_Products_ManytoMany.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Range(1, 100000)]
        public decimal Price { get; set; }

        // Navigation
        public List<Order> Orders { get; set; }
    }
}
