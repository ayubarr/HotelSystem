using HotelSystem.DAL.SqlServer.Helpers;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.DAL.SqlServer.Configuration
{
	/// <summary>
	/// Конфигурация сущности отчета
	/// </summary>
	internal class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(r => r.Id);
            PropertyHelper<Report>.SetDefoultMaxLengthProperties(builder,
                r=> r.Title,
                r=> r.Author,
                r=> r.Body,
                r=> r.Description);

            builder.HasOne(r => r.Emloyee)
                .WithMany(e => e.Reports)
                .HasForeignKey(r => r.EmloyeeId);
        }
    }
}
