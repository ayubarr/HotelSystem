using HotelSystem.DAL.SqlServer.Helpers;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Amount).HasPrecision(15, 2);

            builder.HasOne(p => p.Emloyee)
                .WithMany(e => e.Payments)
                .HasForeignKey(p => p.EmloyeeId);

            builder.HasOne(p => p.Guest)
                    .WithMany(g => g.Payments)
                    .HasForeignKey(p => p.GuestId);

            builder.HasOne(p => p.Room)
                  .WithMany(r => r.Payments)
                  .HasForeignKey(p => p.RoomId);

            builder.HasOne(p => p.ServiceEntity)
               .WithMany(se => se.Payments)
               .HasForeignKey(p => p.ServiceEntityId);

            PropertyHelper<Payment>.SetDefoultMaxLengthProperties(builder,
                p => p.Description);
        }
    }
}
