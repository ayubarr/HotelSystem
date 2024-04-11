using HotelSystem.ApiModels.Auth;
using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Employee;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using HotelSystem.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HotelSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IAuthManager<Employee> _authService;

        public EmployeeController(IEmployeeService employeeService, IAuthManager<Employee> authManager)
        {
            _employeeService = employeeService;
            _authService = authManager;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _employeeService.GetAllAsync();


            var employeeDtos = response.Data.Select(employee => new CreateEmployeeDTO
            {
                Id = employee.Id,
                UserName = employee.UserName,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                MiddleName = employee.MiddleName,
                Email = employee.Email,
            });

            return Ok(employeeDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            var response = await _employeeService.GetByIdAsync(id);
            return Ok(response.Data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(uint id, UpdateEmployeeDTO employeeDto)
        {
            var response = await _employeeService.UpdateAsync(id, employeeDto);
            return Ok(response.Data);
        }

        [Authorize(AuthenticationSchemes = "Bearer", Roles = "Admin, Supervisor")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(uint id)
        {
            var response = await _employeeService.DeleteByIdAsync(id);
            return Ok(response);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var response = await _authService.Login(model);

            if (response.IsSuccess)
            {
                return Ok(response);
            }
            return Unauthorized(response.Message);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var result = await _authService.Register(model);
            //await _employeeService.SetEmployeeNewRoleByIdAsync(result.Data, Roles.Employee);

            return Ok(result);
        }

    }
}
