using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Services.Services.Interfaces
{
    internal interface IBaseService<T> where T : BaseEntity
    {
        /// <summary>
        /// Retrieves all entities.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The task result contains the response with the list of employees or an error if the operation fails.</returns>
        Task<IBaseResponse<IEnumerable<T>>> GetAllAsync();

        /// <summary>
        /// Retrieves an entities by their ID.
        /// </summary>
        /// <param name="Id">The ID of the employee.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response with the employee object or an error if the operation fails.</returns>
        Task<IBaseResponse<T>> GetByIdAsync(uint Id);

        /// <summary>
        /// Updates the details of the specified employee.
        /// </summary>
        /// <param name="employeeDto">The employee object containing the updated details.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response indicating the success or failure of the operation.</returns>
        Task<IBaseResponse<bool>> UpdateAsync(uint id, BaseDTO entitieDto);

        /// <summary>
        /// Deletes the specified employee by their ID.
        /// </summary>
        /// <param name="Id">The ID of the employee to delete.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response indicating the success or failure of the operation.</returns>
        Task<IBaseResponse<bool>> DeleteByIdAsync(uint Id);
    }
}
