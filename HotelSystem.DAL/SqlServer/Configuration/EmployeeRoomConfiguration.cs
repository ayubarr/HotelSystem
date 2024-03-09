using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class EmployeeRoomConfiguration : IEntityTypeConfiguration<EmployeeRoom>
    {
        public void Configure(EntityTypeBuilder<EmployeeRoom> builder)
        {
            throw new NotImplementedException();
        }
    }
}
