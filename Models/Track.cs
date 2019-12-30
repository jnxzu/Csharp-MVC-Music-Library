using System;
using System.ComponentModel.DataAnnotations;

namespace C__MVC___Music_Library.Models
{
    public class Track
    {
        public int Id { get; set; }

        [StringLength(30)]
        [Required]
        public string Title { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public Album Album { get; set; }

        [Required]
        public Artist Artist { get; set; }
    }
}