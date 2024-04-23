﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstracts
{
    public interface IRoomService
    {
        void Create(Room room);
        List<Room> FindAllRooms(Predicate<Room> predicate);
        void MakeReservation(int? roomId, int personCount);

    }
}
