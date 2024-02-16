using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Domain.Models.Entities
{
    public class Payment : BaseEntity
    {
        public decimal? Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Description { get; set; }
    }
}
