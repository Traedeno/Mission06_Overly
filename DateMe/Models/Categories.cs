using System.ComponentModel.DataAnnotations;

namespace Mission06_Overly.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

    }
}
