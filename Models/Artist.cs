using System.ComponentModel.DataAnnotations;

namespace C__MVC___Music_Library.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
    }
}