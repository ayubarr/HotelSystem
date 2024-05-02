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

        public async Task<IBaseResponse<T>> GetByIdAsync(uint Id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync(Id);
                ObjectValidator<T>.CheckIsNotNullObject(entity);

                return ResponseFactory<T>.CreateSuccessResponse(entity);
            }
            catch (Exception ex)
            {
                return ResponseFactory<T>.CreateErrorResponse(ex);

            }
        }

        public async Task<IBaseResponse<bool>> UpdateAsync(uint id, BaseDTO entitieDto)
        {
            try
            {
                var entity = await _repository.Update(()entitieDto);
                ObjectValidator<T>.CheckIsNotNullObject(entity);

                return ResponseFactory<T>.CreateSuccessResponse(entity);
            }
            catch (Exception ex)
            {
                return ResponseFactory<T>.CreateErrorResponse(ex);

            }
        }
    }
}
