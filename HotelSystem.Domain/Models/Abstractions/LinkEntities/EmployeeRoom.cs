using HotelSystem.Domain.Models.Entities;

namespace HotelSystem.Domain.Models.Abstractions.LinkEntities
{
    /// <summary>
    /// Представляет связь между сотрудником отеля (Employee) и номером в отеле (Room).
    /// Каждая запись в этой таблице указывает, какой сотрудник обслуживает какой номер.
    /// </summary>
    public class EmployeeRoom
    {
        /// <summary>
        /// Идентификатор сотрудника (Employee), обслуживающего номер.
        /// </summary>
        public uint EmployeeId { get; set; }

        /// <summary>
        /// Идентификатор номера (Room), обслуживаемого сотрудником.
        /// </summary>
        public uint RoomId { get; set; }

        /// <summary>
        /// Ссылка на сущность сотрудника (Employee), обслуживающего номер.
        /// </summary>
        public Emloyee Employee { get; set; }

        /// <summary>
        /// Ссылка на сущность номера (Room), обслуживаемого сотрудником.
        /// </summary>
        public Room Room { get; set; }
    }
}
