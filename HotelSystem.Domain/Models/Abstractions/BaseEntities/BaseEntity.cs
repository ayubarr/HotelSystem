namespace HotelSystem.Domain.Models.Abstractions.BaseEntities
{
    /// <summary>
    /// Базовая сущность 
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public uint Id { get; set; }
    }
}
