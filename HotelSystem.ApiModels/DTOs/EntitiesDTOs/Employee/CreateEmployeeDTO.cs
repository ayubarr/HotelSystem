using HotelSystem.ApiModels.DTOs.BaseDTOs;

namespace HotelSystem.ApiModels.DTOs.EntitiesDTOs.Employee
{
    public class CreateEmployeeDTO : BaseDTO
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
