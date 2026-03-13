using System.ComponentModel.DataAnnotations;

namespace Customer_Products_ManytoMany.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer Name required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Navigation
        public List<Order> Orders { get; set; }
    }
}

