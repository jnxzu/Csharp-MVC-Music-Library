using MusicLib.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicLib.Data
{
    public class MusicLibContext : DbContext
    {
        public MusicLibContext(DbContextOptions<MusicLibContext> options) : base(options) { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}