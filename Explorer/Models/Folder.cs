using System.ComponentModel.DataAnnotations;

namespace Explorer.Models
{
    public class Folder
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int? ParentID { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}
