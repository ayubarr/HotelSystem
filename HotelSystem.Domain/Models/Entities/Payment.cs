using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Domain.Models.Entities
{
    public class Payment : BaseEntity
    {
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public uint? EmloyeeId { get; set; }
        public Emloyee? Emloyee { get; set; }

        public uint? GuestId { get; set; }
        public Guest? Guest { get; set; }

        public uint? RoomId { get; set; }
        public Room? Room { get; set; }

        public uint? ServiceEntityId { get; set; }
        public ServiceEntity? ServiceEntity { get; set; }
    }
}
