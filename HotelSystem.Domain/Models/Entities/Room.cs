using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.Domain.Models.Entities
{
	/// <summary>
	/// Room - Сущность номера в отеле
	/// <see cref="Number">				Номер комнаты                                               <see/>
	/// <see cref="Type">				Тип номера (стандарт, люкс и т.д.)                          <see/>
	/// <see cref="AmountType">			Тип номера (одноместный, двухместный, трехместный  и т.д.)  <see/>
	/// <see cref="Price">				Цена за проживание в номере за одну ночь                    <see/>
	/// <see cref="IsBooked">			Флаг, указывающий, забронирован ли номер                    <see/>
	/// <see cref="BookingStartDate">	Время начала брони                                          <see/>
	/// <see cref="BookingEndDate">		Время окончания брони                                       <see/>
	/// <see cref="Employees">			Связь many to many											<see/>
	/// <see cref="Payments">			Cвязь one to many											<see/>
	/// </summary>
	public class Room : BaseEntity
    {
        public string Number { get; set; }

        public RoomType? Type { get; set; }

        public RoomsAmountType AmountType { get; set; } = RoomsAmountType.Single;

        public decimal Price { get; set; }

        public bool IsBooked { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }

        public List<EmployeeRoom> Employees { get; set; }
        public List<Payment>? Payments { get; set; }


    }
}
