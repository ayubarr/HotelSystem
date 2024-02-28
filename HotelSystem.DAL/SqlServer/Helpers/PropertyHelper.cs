using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace HotelSystem.DAL.SqlServer.Helpers
{
    internal static class PropertyHelper<T> 
        where T : class
    {
        internal static void SetDefoultMaxLengthProperties(EntityTypeBuilder<T> builder, params Expression<Func<T, string>>[] properties)
        {
            const int defoultMaxLength = 50;

            foreach (var property in properties)
            {
                builder.Property(property).HasMaxLength(defoultMaxLength);
            }

        }
    }
}
