using C__MVC___Music_Library.Models;
using Microsoft.EntityFrameworkCore;

namespace C__MVC___Music_Library.Data
{
    public class MusicLibContext : DbContext
    {
        public MusicLibContext(DbContextOptions<MusicLibContext> options) : base(options) { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}