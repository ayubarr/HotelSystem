using HotelSystem.DAL.SqlServer.Helpers;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class GuestConfiguration : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.HasKey(e => e.Id);

            PropertyHelper<Guest>.SetDefoultMaxLengthProperties(builder,
               g => g.FirstName,
               g => g.LastName,
               g => g.MiddleName,
               g => g.Email,
               g => g.PhoneNumber);

        }
    }
}
