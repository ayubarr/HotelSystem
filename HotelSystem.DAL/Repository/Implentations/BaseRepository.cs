﻿using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.DAL.SqlServer.Context;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Validation;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem.DAL.Repository.Implentations
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            ObjectValidator<AppDbContext>.CheckIsNotNullObject(context);

            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task Create(T entity)
        {
            ObjectValidator<T>.CheckIsNotNullObject(entity);

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            ObjectValidator<T>.CheckIsNotNullObject(entity);

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.FromResult(_dbSet);
        }

        public T GetById(uint id)
        {
            NumberValidator<uint>.IsNotZero(id);

            var entity = GetAll().FirstOrDefault(x => x.Id == id);
            ObjectValidator<T>.CheckIsNotNullObject(entity);
            return entity;
        }

        public async Task<T> GetByIdAsync(uint id)
        {
            NumberValidator<uint>.IsNotZero(id);
            var entity = await GetAllAsync().Result.FirstOrDefaultAsync(x => x.Id == id);
            ObjectValidator<T>.CheckIsNotNullObject(entity);
            return entity;
        }

        public async Task DeleteById(uint id)
        {
            var entity = await GetByIdAsync(id);
            await Delete(entity);
        }

        public async Task Delete(T entity)
        {
            ObjectValidator<T>.CheckIsNotNullObject(entity);

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
