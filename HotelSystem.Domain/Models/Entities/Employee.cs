using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.Domain.Models.Entities
{
    /// <summary>
    /// Сущность сотрудника отеля
    /// </summary>
    public class Employee : ApplicationUser
    {
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// отчество сотрудника
        /// </summary>
        public string MiddleName { get; set; }

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

        public List<EmployeeRoom>? Rooms { get; set; }

        public List<Report>? Reports { get; set; }

        public List<Payment>? Payments { get; set; }

    }
}
