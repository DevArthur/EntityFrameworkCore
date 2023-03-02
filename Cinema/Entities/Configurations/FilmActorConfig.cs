using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Entities.Configurations
{
    public class FilmActorConfig : IEntityTypeConfiguration<FilmActor>
    {
        public void Configure(EntityTypeBuilder<FilmActor> builder)
        {
            builder.Property(p => p.Character)
            .HasMaxLength(150);

            builder.HasKey(p => new { p.FilmId, p.ActorId });
        }
    }
}
