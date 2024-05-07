using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.ApiModels.DTOs.EntitiesDTOs.Room
{
    public class UpdateRoomDTO : BaseDTO
    {
        public string Number { get; set; }

        public RoomType? Type { get; set; }

        public RoomsAmountType AmountType { get; set; } = RoomsAmountType.Single;

        public decimal Price { get; set; }

        public bool IsBooked { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }
    }
}
