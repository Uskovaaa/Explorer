using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Explorer.Models
{
    public class Extension
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Type { get; set; }
        public string? Icon { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}
