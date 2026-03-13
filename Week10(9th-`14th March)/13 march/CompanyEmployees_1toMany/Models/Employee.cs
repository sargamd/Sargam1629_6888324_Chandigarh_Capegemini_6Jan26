using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyEmployees_1toMany.Models
{
    [Table("tblEmployees")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        public string Position { get; set; }

        // Foreign Key
        public int CompanyId { get; set; }

        // Navigation
        public Company Company { get; set; }
    }
}
