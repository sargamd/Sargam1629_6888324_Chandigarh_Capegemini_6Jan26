using System.ComponentModel.DataAnnotations;

namespace ECommerceWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 100000)]
        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
