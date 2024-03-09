using HotelSystem.DAL.SqlServer.Configuration;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem.DAL.SqlServer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(EmployeeConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(typeof(GuestConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(typeof(ReportConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(typeof(ServiceEntityConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(typeof(RoomConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(typeof(PaymentConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(typeof(ServiceEntityGuestConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(typeof(EmployeeRoomConfiguration).Assembly);
        }
    }
}
