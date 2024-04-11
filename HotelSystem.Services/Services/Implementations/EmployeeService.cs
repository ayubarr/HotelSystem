using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Employee;
using HotelSystem.ApiModels.Response.Helpers;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using HotelSystem.Validation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem.Services.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly UserManager<Employee> _userManager;


        public EmployeeService(UserManager<Employee> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IBaseResponse<IEnumerable<Employee>>> GetAllAsync()
        {
            try
            {
                var users = await _userManager.Users.ToListAsync();
                ObjectValidator<IEnumerable<Employee>>.CheckIsNotNullObject(users);

                return ResponseFactory<IEnumerable<Employee>>.CreateSuccessResponse(users);
            }
            catch (ArgumentNullException ex)
            {
                return ResponseFactory<IEnumerable<Employee>>.CreateNotFoundResponse(ex);
            }
            catch (Exception ex)
            {
                return ResponseFactory<IEnumerable<Employee>>.CreateErrorResponse(ex);
            }
        }

        public async Task<IBaseResponse<Employee>> GetByIdAsync(uint employeeId)
        {
            try
            {
                NumberValidator<uint>.IsNotZero(employeeId);

                var user = await _userManager.FindByIdAsync(employeeId.ToString());
                ObjectValidator<Employee>.CheckIsNotNullObject(user);

                return ResponseFactory<Employee>.CreateSuccessResponse(user);
            }
            catch (ArgumentNullException ex)
            {
                return ResponseFactory<Employee>.CreateNotFoundResponse(ex);
            }
            catch (Exception ex)
            {
                return ResponseFactory<Employee>.CreateErrorResponse(ex);
            }
        }

        public async Task<IBaseResponse<bool>> UpdateAsync(uint id, UpdateEmployeeDTO employeeDto)
        {
            try
            {
                ObjectValidator<UpdateEmployeeDTO>.CheckIsNotNullObject(employeeDto);
                NumberValidator<uint>.IsNotZero(id);

                var employee = await _userManager.FindByIdAsync(id.ToString());
                if (employee is null)
                    throw new ArgumentNullException("User Not found");

                employee.Email = employeeDto.Email;
                employee.FirstName = employeeDto.FirstName;
                employee.LastName = employeeDto.LastName;
                employee.MiddleName = employeeDto.MiddleName;

                await _userManager.UpdateAsync(employee);

                return ResponseFactory<bool>.CreateSuccessResponse(true);
            }
            catch (ArgumentNullException ex)
            {
                return ResponseFactory<bool>.CreateNotFoundResponse(ex);
            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);
            }
        }

        public async Task<IBaseResponse<bool>> DeleteByIdAsync(uint employeeId)
        {
            try
            {
                NumberValidator<uint>.IsNotZero(employeeId);

                var employee = await _userManager.FindByIdAsync(employeeId.ToString());
                ObjectValidator<Employee>.CheckIsNotNullObject(employee);

                var result = await _userManager.DeleteAsync(employee);
                if (result.Succeeded)
                {
                    return ResponseFactory<bool>.CreateSuccessResponse(true);
                }
                else
                {
                    return ResponseFactory<bool>.CreateErrorResponse(new Exception("Failed to delete user."));
                }
            }
            catch (ArgumentNullException ex)
            {
                return ResponseFactory<bool>.CreateNotFoundResponse(ex);
            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);
            }
        }
    }
}
