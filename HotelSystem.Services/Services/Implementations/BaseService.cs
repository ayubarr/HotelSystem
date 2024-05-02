using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Employee;
using HotelSystem.ApiModels.Response.Helpers;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using HotelSystem.Validation;

namespace HotelSystem.Services.Services.Implementations
{
    public class BaseService<T> : IBaseService<T>
        where T : BaseEntity
    {
        private readonly IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IBaseResponse<bool>> DeleteByIdAsync(uint Id)
        {
            try
            {
                NumberValidator<uint>.IsNotZero(Id);
                await _repository.DeleteById(Id);
                return ResponseFactory<bool>.CreateSuccessResponse(true);

            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);
            }
        }

        public async Task<IBaseResponse<IEnumerable<T>>> GetAllAsync()
        {
            try
            {
                var entities = await _repository.GetAllAsync();
                ObjectValidator<IQueryable<T>>.CheckIsNotNullObject(entities);

                return ResponseFactory<IEnumerable<T>>.CreateSuccessResponse(entities);
            }
            catch(Exception ex)
            {
                return ResponseFactory<IEnumerable<T>>.CreateErrorResponse(ex);

            }
        }

        public Task<IBaseResponse<T>> GetByIdAsync(uint employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> UpdateAsync(uint id, BaseDTO entitieDto)
        {
            throw new NotImplementedException();
        }
    }
}
