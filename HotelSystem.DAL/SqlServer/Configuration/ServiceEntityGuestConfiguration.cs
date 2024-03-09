using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class ServiceEntityGuestConfiguration : IEntityTypeConfiguration<ServiceEntityGuest>
    {
        public void Configure(EntityTypeBuilder<ServiceEntityGuest> builder)
        {
            builder.HasKey(seg => new { seg.ServiceEntityId, seg.GuestId });

            builder.HasOne(seg => seg.Guest)
                .WithMany(g => g.ServiceEntities)
                .HasForeignKey(seg => seg.GuestId);

            builder.HasOne(seg => seg.ServiceEntity)
                  .WithMany(se => se.Guests)
                .HasForeignKey(seg => seg.ServiceEntityId);
        }
    }
}
