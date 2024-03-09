using HotelSystem.DAL.SqlServer.Helpers;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace HotelSystem.DAL.SqlServer.Configuration
{
	/// <summary>
	/// Конфигурация сущности сотрудника отеля
	/// </summary>
	public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Salary).HasPrecision(15, 2);

            builder.Property(e => e.Department)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(e => e.Position)
                .IsRequired()
                .HasColumnType("int");

            PropertyHelper<Employee>.SetDefoultMaxLengthProperties(builder,
               e => e.UserName,
               e => e.NormalizedUserName,
               e => e.FirstName,
               e => e.LastName,
               e => e.MiddleName,
               e => e.Email,
               e => e.NormalizedEmail,
               e => e.PasswordHash,
               e => e.SecurityStamp,
               e => e.ConcurrencyStamp);          
        }       
    }
}
