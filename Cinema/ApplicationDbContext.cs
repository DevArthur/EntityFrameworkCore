using CinemaApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Change the table and schema names
            //modelBuilder.Entity<Genre>()
            //    .ToTable(name: "GenreTable", schema: "movies");
                
            modelBuilder.Entity<Genre>().HasKey("Id");
            // modelBuilder.Entity<Genre>().Property(p => p.Name).HasMaxLength(150);
            // modelBuilder.Entity<Genre>().Property(p => p.Name).IsRequired();
            // Or you can configure many aspects for the same column:
            modelBuilder.Entity<Genre>().Property(p => p.Name)
                .HasMaxLength(150)
                .IsRequired();
            //change column name
            //.HasColumnName("GenreName");

            modelBuilder.Entity<Actor>().Property(p => p.Name)
                .HasMaxLength(150);

            modelBuilder.Entity<Actor>().Property(p => p.BirthDate)
                .HasColumnType("date");

            modelBuilder.Entity<Cinema>().Property(p => p.Price)
                .HasPrecision(precision: 9, scale: 2);

            modelBuilder.Entity<Film>().Property(p => p.Title)
                .HasMaxLength(250)
                .IsRequired();

            modelBuilder.Entity<Film>().Property(p => p.ReleaseDate)
                .HasColumnType("date");

            modelBuilder.Entity<Film>().Property(p => p.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
