using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Entities.Configurations
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(p => p.Title)
                .HasMaxLength(250)
                .IsRequired();

            //modelBuilder.Entity<Film>().Property(p => p.ReleaseDate)
            //    .HasColumnType("date");

            builder.Property(p => p.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
