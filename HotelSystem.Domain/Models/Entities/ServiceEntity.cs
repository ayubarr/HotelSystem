using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.Domain.Models.Entities
{
	/// <summary>
	/// ServiceEntity - Сущность дополнительной услуги, предоставляемой отелем
	/// <see cref="Name">			Название услуги				<see/>
	/// <see cref="Description">	Описание услуги						<see/>
	/// <see cref="Price">			Стоимость услуги                                                                           <see/>
	/// <see cref="IsAvailable">	Доступность услуги (например, "включено в стоимость проживания" или "дополнительно платно")<see/>
	/// <see cref="ServiceType">	Перечисление, представляющее типы услуг					<see/>
	/// <see cref="Guests">						<see/>
	/// <see cref="Payments">							<see/>
	/// </summary>
	public class ServiceEntity : BaseEntity
    {
        /// <summary>
        /// Название услуги
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание услуги
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Стоимость услуги
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Доступность услуги (например, "включено в стоимость проживания" или "дополнительно платно")
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Перечисление, представляющее типы услуг
        /// </summary>Ы
        public ServiceType ServiceType { get; set; }

        public List<ServiceEntityGuest>? Guests { get; set; }
        public List<Payment>? Payments { get; set; }

    }
}
