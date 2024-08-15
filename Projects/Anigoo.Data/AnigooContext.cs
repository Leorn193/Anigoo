using Anigoo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Anigoo.Data
{
    public class AnigooContext : DbContext
    {
        public AnigooContext(DbContextOptions<AnigooContext> options) : base(options)
        {
            
        }

        public DbSet<Anime> Anime { get; set; }
        public DbSet<AnimeStreaming> AnimeStreaming { get; set; }
        public DbSet<Episodio> Episodio { get; set; }
        public DbSet<Favorito> Favorito { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Episodio> Streaming { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
