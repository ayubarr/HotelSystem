using HotelSystem.DAL.SqlServer.Helpers;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
	/// <summary>
	/// Конфигурация сущности дополнительной услуги, предоставляемой отелем
	/// </summary>
	public class ServiceEntityConfiguration : IEntityTypeConfiguration<ServiceEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceEntity> builder)
        {
            builder.HasKey(se => se.Id);
            builder.Property(se => se.Price).HasPrecision(15, 2);

            PropertyHelper<ServiceEntity>.SetDefoultMaxLengthProperties(builder,
                se => se.Name,
                se => se.Description);
        }
    }
}
