using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyEmployees_1toMany.Models
{
    [Table("tblCompany")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Company name required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        // Navigation Property
        public List<Employee> Employees { get; set; }
    }
}
