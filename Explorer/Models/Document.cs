using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Explorer.Models
{
    public class Document
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ExtensionID { get; set; }
        public int? FolderID { get; set; }
        public string? Content { get; set; }

        [NotMapped]
        public IFormFile FormFile { get; set; }
        public Folder Folder { get; set; }
        public Extension Extension { get; set; }
    }
}
