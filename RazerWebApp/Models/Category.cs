using System.ComponentModel.DataAnnotations;

namespace RazerWebApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order for category must be between 1-100")]
        public string DisplayOrder { get; set; }
    }
}
