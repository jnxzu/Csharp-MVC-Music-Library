using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MusicLib.Models
{
    public class AlbumArtistViewModel
    {
        public List<Album> Albums { get; set; }
        public SelectList Artists { get; set; }
        public string albumArtist { get; set; }
    }
}