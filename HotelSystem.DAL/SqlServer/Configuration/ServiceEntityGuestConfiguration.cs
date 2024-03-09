using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class ServiceEntityGuestConfiguration : IEntityTypeConfiguration<ServiceEntityGuest>
    {
        public void Configure(EntityTypeBuilder<ServiceEntityGuest> builder)
        {
            throw new NotImplementedException();
        }
    }
}
