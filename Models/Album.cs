using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MusicLib.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        public virtual Artist Artist { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 5)]
        [Display(Name = "Rating")]
        [Required]
        public int Rating { get; set; }

        [Required]
        public int ArtistId { get; set; }
    }
}