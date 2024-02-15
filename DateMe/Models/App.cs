using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DateMe.Models
{
    public class App
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "This Answer field is required.")]
        public string Category { get; set; }
        [Required(ErrorMessage = "This Answer field is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This Answer field is required.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "This Answer field is required.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "This Answer field is required.")]
        public string Rating {  get; set; }
        public string? Lent { get; set; }
        public bool Edit { get; set; }
        [StringLength(25)]
        public string? Note { get; set; }



     }
}
