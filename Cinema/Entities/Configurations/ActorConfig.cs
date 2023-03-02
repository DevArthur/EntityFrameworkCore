using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Entities.Configurations
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(150);

            //modelBuilder.Entity<Actor>().Property(p => p.BirthDate)
            //    .HasColumnType("date");
        }
    }
}
