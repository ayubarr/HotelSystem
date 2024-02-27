using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace HotelSystem.DAL.SqlServer.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(u => u.Id);

            SetDefoultMaxLengthProperties(builder,
               u => u.UserName,
               u => u.NormalizedUserName,
               u => u.FirstName,
               u => u.LastName,
               u => u.MiddleName,
               u => u.Email,
               u => u.NormalizedEmail,
               u => u.PasswordHash,
               u => u.SecurityStamp,
               u => u.ConcurrencyStamp);
        }

        private void SetDefoultMaxLengthProperties(EntityTypeBuilder<Employee> builder, params Expression<Func<Employee, string>>[] properties)
        {
            const int defoultMaxLength = 30;

            foreach (var property in properties)
            {
                builder.Property(property).HasMaxLength(defoultMaxLength);
            }

        }
    }
}
