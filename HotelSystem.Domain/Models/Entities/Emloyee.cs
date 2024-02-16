using HotelSystem.Domain.Models.Abstractions.BaseUsers;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.Domain.Models.Entities
{
    /// <summary>
    /// Сущность сотрудника отеля
    /// </summary>
    public class Emloyee : ApplicationUser
    {
        /// <summary>
        /// Тип подразделения сотрудника
        /// </summary>
        public DepartmentType Department { get; set; }

        /// <summary>
        /// Тип должности сотрудника
        /// </summary>
        public PositionType Position { get; set; }

        /// <summary>
        /// Заработная плата сотрудника
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Дата принятия на работу
        /// </summary>
        public DateTime HireDate { get; set; }
    }
}
