using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.DAL.SqlServer.Context;
using HotelSystem.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.DAL.Repository.Implentations
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {

        public RoomRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Room> GetRoomByNumberAsync(string roomNumber)
        {       
           return await GetAll()
                .Where(x => x.Number == roomNumber)
                .FirstOrDefaultAsync();
        }
    }
}
