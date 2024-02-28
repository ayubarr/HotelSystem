using HotelSystem.DAL.SqlServer.Helpers;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Type)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(r => r.AmountType)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(r => r.Number).HasMaxLength(10);

            builder.Property(r => r.Price).HasPrecision(15, 2);

        }
    }
}
