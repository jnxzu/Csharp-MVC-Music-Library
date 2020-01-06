using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace C__MVC___Music_Library.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}