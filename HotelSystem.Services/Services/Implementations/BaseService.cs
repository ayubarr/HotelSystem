﻿using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.ApiModels.Response.Helpers;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Services.Mapping;
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

        public async Task<IBaseResponse<T>> CreateAsync<Tmodel>(Tmodel entityDTO) where Tmodel : BaseDTO
        {
            try
            {
                ObjectValidator<Tmodel>.CheckIsNotNullObject(entityDTO);

                var entity = MapperHelperForEntity<Tmodel, T>.Map(entityDTO);

                await _repository.Create(entity);

                return ResponseFactory<T>.CreateSuccessResponse(entity);
            }
            catch (ArgumentNullException argNullException)
            {
                return ResponseFactory<T>.CreateNotFoundResponse(argNullException);
            }
            catch (Exception exception)
            {
                return ResponseFactory<T>.CreateErrorResponse(exception);
            }
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
            catch (Exception ex)
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

        public async Task<IBaseResponse<bool>> UpdateAsync<Tmodel>(Tmodel entitieDto) where Tmodel : BaseDTO
        {
            try
            {
                ObjectValidator<Tmodel>.CheckIsNotNullObject(entitieDto);
                T entity = MapperHelperForEntity<Tmodel, T>.Map(entitieDto);

                await _repository.Update(entity);
                ObjectValidator<T>.CheckIsNotNullObject(entity);

                return ResponseFactory<bool>.CreateSuccessResponse(true);
            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);

            }
        }
    }
}
