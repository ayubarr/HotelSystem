using HotelSystem.Domain.Models.Entities;

namespace HotelSystem.Domain.Models.Abstractions.LinkEntities
{
    /// <summary>
    /// Представляет связь между гостем отеля (Guest) и услугой (ServiceEntity).
    /// Каждая запись в этой таблице указывает, какие услуги предоставляются конкретному гостю.
    /// </summary>
    public class ServiceEntityGuest
    {
        /// <summary>
        /// Идентификатор гостя (Guest), которому предоставляется услуга.
        /// </summary>
        public uint GuestId { get; set; }

        /// <summary>
        /// Идентификатор услуги (ServiceEntity), предоставляемой гостю.
        /// </summary>
        public uint ServiceEntityId { get; set; }

        /// <summary>
        /// Ссылка на сущность гостя (Guest), которому предоставляется услуга.
        /// </summary>
        public Guest Guest { get; set; }

        /// <summary>
        /// Ссылка на сущность услуги (ServiceEntity), предоставляемой гостю.
        /// </summary>
        public ServiceEntity ServiceEntity { get; set; }
    }
}
