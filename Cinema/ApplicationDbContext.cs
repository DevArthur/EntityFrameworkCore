using CinemaApp.Entities;
using CinemaApp.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CinemaApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        // overriding this method, you can set a data type by default, for example: When you declare
        // a DateTime type in a property, by default it will be SQL date.
        // This is the reason the DateTime properties are commented in the Api Fluent.
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // It's a way to do it for every single classConfig:
            // modelBuilder.ApplyConfiguration(new GenreConfig());

            // Or you can do it for assambly like this: This is for any class that implements
            // IEntityTypeConfiguration Interface
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<CinemaRoom> CinemasRooms { get; set; }
        public DbSet<FilmActor> FilmsActors { get; set;}
    }
}
