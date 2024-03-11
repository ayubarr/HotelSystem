using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.Domain.Models.Enums;

namespace HotelSystem.ApiModels.DTOs.EntitiesDTOs.Employee
{
    public class UpdateEmployeeDTO : BaseDTO
    {
        public string? Email { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? MiddleName { get; set; }

        public decimal? Salary { get; set; }

        public string? PhoneNumber { get; set; }

        public PositionType? Position { get; set; }

        public DepartmentType? Department { get; set; }
    }
}
