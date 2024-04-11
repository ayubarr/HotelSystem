using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Employee;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services.Services.Interfaces
{
    /// <summary>
    /// Service for managing employee entities and their roles, projects, and tasks.
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Retrieves all employees.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The task result contains the response with the list of employees or an error if the operation fails.</returns>
        Task<IBaseResponse<IEnumerable<Employee>>> GetAllAsync();

        /// <summary>
        /// Retrieves an employee by their ID.
        /// </summary>
        /// <param name="employeeId">The ID of the employee.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response with the employee object or an error if the operation fails.</returns>
        Task<IBaseResponse<Employee>> GetByIdAsync(uint employeeId);

        /// <summary>
        /// Updates the details of the specified employee.
        /// </summary>
        /// <param name="employeeDto">The employee object containing the updated details.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response indicating the success or failure of the operation.</returns>
        Task<IBaseResponse<bool>> UpdateAsync(uint id, UpdateEmployeeDTO employeeDto);

        /// <summary>
        /// Deletes the specified employee by their ID.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to delete.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response indicating the success or failure of the operation.</returns>
        Task<IBaseResponse<bool>> DeleteByIdAsync(uint employeeId);

        /// <summary>
        /// Sets the specified employee as an Role.
        /// </summary>
        /// <param name="employeeId">The ID of the employee.</param>
        /// <param name="roleType">The type of role to assign.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response indicating the success or failure of the operation.</returns>
    }
}
