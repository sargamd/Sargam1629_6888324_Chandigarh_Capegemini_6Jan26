using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookPublisherCodeFIrst.Models
{
    [Table("tblBooks")]
    public class BookModel
    {
        
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public string Category { get; set; }
        public string Publisher { get; set; }

        public int PublishedYear { get; set; }
    }
}
