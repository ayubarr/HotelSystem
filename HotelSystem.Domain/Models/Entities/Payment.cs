using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Domain.Models.Entities
{
    /// <summary> 
    /// Класс Payment - Оплата, предназначен для отслеживание оплаты за проживание и услуги.
    /// <see cref="Amount">							<see/>
    /// <see cref="Date">							<see/>
    /// <see cref="Description">					<see/>
    /// <see cref="EmloyeeId">						<see/>
    /// <see cref="Emloyee">						<see/>
    /// <see cref="GuestId">						<see/>
    /// <see cref="Guest">							<see/>
    /// <see cref="RoomId">							<see/>
    /// <see cref="Room">							<see/>
    /// <see cref="ServiceEntityId">				<see/>
    /// <see cref="ServiceEntity">					<see/>
    /// </summary>
    public class Payment : BaseEntity
    {
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public uint? EmloyeeId { get; set; }
        public Employee? Emloyee { get; set; }

        public uint? GuestId { get; set; }
        public Guest? Guest { get; set; }

        public uint? RoomId { get; set; }
        public Room? Room { get; set; }

        public uint? ServiceEntityId { get; set; }
        public ServiceEntity? ServiceEntity { get; set; }
    }
}
