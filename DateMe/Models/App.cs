using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DateMe.Models
{
    public class App
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Mission06_Overly.Models.Categories? Category { get; set; }
        [Required(ErrorMessage = "You must enter a movie title.")]
        public string Title { get; set; }
        [Range(1888, 2024, ErrorMessage = "Enter in a year greater than 1888.")]
        [Required]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating {  get; set; }
        [Required(ErrorMessage = "Please specify if the move is edited.")]
        public int Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage ="Enter if the movie has been copied to plex.")]
        public int CopiedToPlex { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }

     }
}
