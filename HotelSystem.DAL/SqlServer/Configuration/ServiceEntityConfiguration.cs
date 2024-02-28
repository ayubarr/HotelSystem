using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class ServiceEntityConfiguration : IEntityTypeConfiguration<ServiceEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
