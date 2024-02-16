using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.Domain.Models.Entities
{
    /// <summary>
    /// Сущность номера в отеле
    /// </summary>
    public class Room : BaseEntity
    {
        /// <summary>
        /// Номер комнаты
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// Тип номера (стандарт, люкс и т.д.)
        /// </summary>
        public RoomType Type { get; set; }

        /// <summary>
        /// Тип номера (одноместный, двухместный, трехместный  и т.д.)
        /// </summary>
        public RoomsAmountType AmountType { get; set; }

        /// <summary>
        /// Цена за проживание в номере за одну ночь
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Флаг, указывающий, забронирован ли номер
        /// </summary>
        public bool IsBooked { get; set; }
    }
}
