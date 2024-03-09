using HotelSystem.DAL.Repository.Interfaces;
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

        public BaseRepository(AppDbContext context, DbSet<T> dbSet)
        {
            ObjectValidator<AppDbContext>.CheckIsNotNullObject(context);

            _context = context;
            _dbSet = dbSet;
        }

        public async Task Create(T entity)
        {
            ObjectValidator<T>.CheckIsNotNullObject(entity);
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        //по анологии с Create
        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        //по анологии с Create
        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        //вспомни что такое _dbSet
        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        //Task.FromResult - подсказка, вспомни синтаксис асинхронности
        //То же самое что GetAll() только асинхронно
        public Task<IQueryable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        //Валидация + LINQ метод(чтобы получить результат асинхронной операции пиши в конце .Result : Пример GetAllAsync.Result)
        public T GetById(uint id)
        {
            throw new NotImplementedException();
        }

        //Валидация + LINQ только асинхронно всё тоже самое что в GetById
        public Task<T> GetByIdAsync(uint id)
        {
            throw new NotImplementedException();
        }
    }
}
