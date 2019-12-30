using System;

namespace C__MVC___Music_Library.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Rating { get; set; }
        public Artist Artist { get; set; }
    }
}