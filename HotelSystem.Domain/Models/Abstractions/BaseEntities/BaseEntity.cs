namespace HotelSystem.Domain.Models.Abstractions.BaseEntities
{
	/// <summary>
	/// BaseEntity - Базовая сущность 
	/// <see cref="Id"> Идентификатор   <see/>
	/// </summary>
	public abstract class BaseEntity
    {
        public uint Id { get; set; }
    }
}
