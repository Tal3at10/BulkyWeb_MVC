using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required] // means no nullable values in the Name Column
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
