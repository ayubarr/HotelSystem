using HotelSystem.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.DAL.Repository.Interfaces
{
    public interface IRoomRepository : IBaseRepository<Room>
    {
        public Task<Room> GetRoomByNumberAsync(string roomNumber);

    }
}
