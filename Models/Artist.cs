using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicLib.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Popularity { get; set; }

        [RegularExpression(@"(\w+(\s\w)?)(, \w+(\s\w)?)*", ErrorMessage = "Invalid Genres")]
        [StringLength(50)]
        public string Genres { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}