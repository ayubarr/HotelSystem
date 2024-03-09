using HotelSystem.Domain.Models.Abstractions.BaseEntities;


namespace HotelSystem.DAL.Repository.Interfaces
{
    public interface IBaseRepository<T>
        where T : BaseEntity
    {
        public Task Create(T entity);

        public IQueryable<T> GetAll();

        public T GetById(uint id);

        public Task<IQueryable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(uint id);

        public Task Update(T entity);

        public Task Delete(T entity);
    }
}
