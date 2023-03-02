using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Entities.Configurations
{
    public class CinemaRoomConfig : IEntityTypeConfiguration<CinemaRoom>
    {
        public void Configure(EntityTypeBuilder<CinemaRoom> builder)
        {
            builder.Property(p => p.Price)
                .HasPrecision(precision: 9, scale: 2);

            builder.Property(p => p.CinemaRoomType)
                .HasDefaultValue(CinemaRoomType.TwoDimensions);
        }
    }
}
