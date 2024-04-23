using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concretes
{
    public class RoomService : IRoomService
    { 
        public async Task  Create(Room room)
        {
          await  AppDb.rooms.Add(room);
        }

        public async List<Room> FindAllRooms(Predicate<Room> predicate)
        {
          return await AppDb.rooms.FindAll(predicate);
        }

        public async  Task MakeReservation(int? roomId, int personCount)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("room id not found");

             }
            Room room = AppDb.rooms.FirstOrDefault(x => x.Id == roomId);    
            if (room == null)
            {
                throw new NotAvaibleException("gonderdiyiniz id-li otaq tapilmadi");
            }
            if(room.PersonCapacity > personCount)
            {
                throw new NotAvaibleException("otaq musait deyil");
            };
            room.IsAvaible = true;
        }
    }
}
