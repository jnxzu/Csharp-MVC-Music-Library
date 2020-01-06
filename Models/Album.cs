using System;
using System.ComponentModel.DataAnnotations;

namespace C__MVC___Music_Library.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [StringLength(60)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 10)]
        public decimal Rating { get; set; }

        [Required]
        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}