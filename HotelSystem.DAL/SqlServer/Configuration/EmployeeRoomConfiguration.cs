using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
	/// <summary>
	/// Конфигурация many many Представляет связь между сотрудником отеля (Employee) и номером в отеле (Room).
	/// Каждая запись в этой таблице указывает, какой сотрудник обслуживает какой номер.
	/// </summary>
	public class EmployeeRoomConfiguration : IEntityTypeConfiguration<EmployeeRoom>
    {
        public void Configure(EntityTypeBuilder<EmployeeRoom> builder)
        {
            builder.HasKey(er => new { er.EmployeeId, er.RoomId });

            builder.HasOne(er => er.Employee)
                .WithMany(e => e.Rooms)
                .HasForeignKey(er => er.EmployeeId);

            builder.HasOne(er => er.Room)
                  .WithMany(e => e.Employees)
                .HasForeignKey(er => er.RoomId);
        }
    }
}
