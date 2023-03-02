using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CinemaApp.Entities.Configurations
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            // Change the table and schema names
            // modelBuilder.Entity<Genre>()
            //    .ToTable(name: "GenreTable", schema: "movies");

            builder.HasKey("Id");
            // modelBuilder.Entity<Genre>().Property(p => p.Name).HasMaxLength(150);
            // modelBuilder.Entity<Genre>().Property(p => p.Name).IsRequired();
            // Or you can configure many aspects for the same column:
            builder.Property(p => p.Name)
                .HasMaxLength(150)
                .IsRequired();
            // change column name
            // .HasColumnName("GenreName");
        }
    }
}
