using HotelSystem.Domain.Models.Entities;

namespace HotelSystem.Domain.Models.Abstractions.LinkEntities
{
	/// <summary>
	/// EmployeeRoom - Представляет связь между сотрудником отеля (Employee) и номером в отеле (Room).
	/// Каждая запись в этой таблице указывает, какой сотрудник обслуживает какой номер.
	/// <see cref="EmployeeId">     Идентификатор сотрудника (Employee), обслуживающего номер.      </see>
	/// <see cref="RoomId">         Идентификатор номера (Room), обслуживаемого сотрудником.        </see>
	/// <see cref="Employee">       Ссылка на сущность сотрудника (Employee), обслуживающего номер. </see>
	/// <see cref="Room"/>          Ссылка на сущность номера (Room), обслуживаемого сотрудником.   </see>
	/// </summary>
	public class EmployeeRoom
    {
        public uint EmployeeId { get; set; }

        public uint RoomId { get; set; }

        public Employee Employee { get; set; }

        public Room Room { get; set; }
    }
}
