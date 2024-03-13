using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.Domain.Models.Entities
{
	/// <summary>
	/// ServiceEntity - Сущность дополнительной услуги, предоставляемой отелем
	/// <see cref="Name">			Название услуги																				<see/>
	/// <see cref="Description">	Описание услуги																				<see/>
	/// <see cref="Price">			Стоимость услуги																			<see/>
	/// <see cref="IsAvailable">	Доступность услуги (например, "включено в стоимость проживания" или "дополнительно платно")	<see/>
	/// <see cref="ServiceType">	Перечисление, представляющее типы услуг														<see/>
	/// <see cref="Guests">			связь many to many																			<see/>
	/// <see cref="Payments">		связь one to many																			<see/>
	/// </summary>
	public class ServiceEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public ServiceType ServiceType { get; set; }

        public List<ServiceEntityGuest>? Guests { get; set; }
        public List<Payment>? Payments { get; set; }

    }
}
