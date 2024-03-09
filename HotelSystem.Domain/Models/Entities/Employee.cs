using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using HotelSystem.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelSystem.Domain.Models.Entities
{
	/// <summary>
	/// Employee - Сущность сотрудника отеля
	/// <see cref="FirstName">      Имя сотрудника                  </see>
	/// <see cref="LastName">       Фамилия сотрудника              </see>
	/// <see cref="MiddleName">     Отчество сотрудника             </see>
	/// <see cref="Department">     Тип подразделения сотрудника    </see>
	/// <see cref="Position">       Тип должности сотрудника        </see>
	/// <see cref="Salary">         Заработная плата сотрудника     </see>
	/// <see cref="HireDate">       Дата принятия на работу         </see>
    /// <see cref="Rooms">          Связь one to many               </see>
    /// <see cref="Reports">        Связь one to many               </see>
    /// <see cref="Payments">       Связь one to many               </see>
	/// </summary>
	public class Employee : ApplicationUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string MiddleName { get; set; }

        [Range(1, 4)]
        public DepartmentType Department { get; set; }

        [Range(1, 4)]
        public PositionType Position { get; set; }

        public decimal Salary { get; set; }

        public DateTime HireDate { get; set; }

        public List<EmployeeRoom>? Rooms { get; set; }

        public List<Report>? Reports { get; set; }

        public List<Payment>? Payments { get; set; }

    }
}
