using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concretes
{
    public class HotelService : IHotelService
    {
        public Hotel ChooseHotel(string name)
        {
            return AppDb.hotels.Find(x=> x.Name ==name);
                   }

        public void Create(Hotel hotel)
        {
          AppDb.hotels.Add(hotel);
        }

        public List<Hotel> GetAll()
        {
            return AppDb.hotels;
        }
    }
}
