using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.Domain.Models.Entities
{
    /// <summary>
    /// Сущность дополнительной услуги, предоставляемой отелем
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
    }
}
