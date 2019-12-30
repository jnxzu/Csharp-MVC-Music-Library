using System;

namespace C__MVC___Music_Library.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public Album Album { get; set; }
        public Artist Artist { get; set; }
    }
}