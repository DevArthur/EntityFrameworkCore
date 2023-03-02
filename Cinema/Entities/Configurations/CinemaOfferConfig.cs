using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Entities.Configurations
{
    public class CinemaOfferConfig : IEntityTypeConfiguration<CinemaOffer>
    {
        public void Configure(EntityTypeBuilder<CinemaOffer> builder)
        {
            builder.Property(p => p.DiscountRate)
                .HasPrecision(precision: 5, scale: 2);

            //modelBuilder.Entity<CinemaOffer>().Property(p => p.StartDate)
            //    .HasColumnType ("date");

            //modelBuilder.Entity<CinemaOffer>().Property(p => p.FinishDate)
            //    .HasColumnType("date");
        }
    }
}
