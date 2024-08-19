using Anigoo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;

namespace Anigoo.Data
{
    public class AnigooContext : DbContext
    {
        public AnigooContext(DbContextOptions<AnigooContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //ForeignKeys Banco
            modelBuilder.Entity<AnimeGenero>().HasOne(x => x.Anime)
                                              .WithMany(x => x.AnimeGenero)
                                              .HasForeignKey(x => x.Id_Anime);

            modelBuilder.Entity<AnimeGenero>().HasOne(x => x.Genero)
                                              .WithMany(x => x.AnimeGenero)
                                              .HasForeignKey(x => x.Id_Genero);

            modelBuilder.Entity<AnimeStreaming>().HasOne(x => x.Anime)
                                                 .WithMany(x => x.AnimeStreaming)
                                                 .HasForeignKey(x => x.Id_Anime);

            modelBuilder.Entity<AnimeStreaming>().HasOne(x => x.Streaming)
                                                 .WithMany(x => x.AnimeStreaming)
                                                 .HasForeignKey(x => x.Id_Streaming);

            modelBuilder.Entity<Avaliacao>().HasOne(x => x.Anime)
                                            .WithMany(x => x.Avaliacao)
                                            .HasForeignKey(x => x.Id_Anime);

            modelBuilder.Entity<Avaliacao>().HasOne(x => x.Usuario)
                                            .WithMany(x => x.Avaliacao)
                                            .HasForeignKey(x => x.Id_Usuario);

            modelBuilder.Entity<Episodio>().HasOne(x => x.Anime)
                                           .WithMany(x => x.Episodio)
                                           .HasForeignKey(x => x.Id_Anime);
        }

        public DbSet<Anime> Anime { get; set; }
        public DbSet<AnimeStreaming> AnimeStreaming { get; set; }
        public DbSet<Episodio> Episodio { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Episodio> Streaming { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<AnimeGenero> AnimeGenero { get; set; }
    }
}
