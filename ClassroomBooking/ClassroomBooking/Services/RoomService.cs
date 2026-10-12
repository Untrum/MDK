using ClassroomBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomBooking.Services
{
    internal class RoomService
    {
        private readonly List<Room> rooms = new List<Room>
        {
            new Room { Id = 1, Number = "301", ComputerCount = 15, IsAvailable = true },
            new Room { Id = 2, Number = "302", ComputerCount = 20, IsAvailable = true },
            new Room { Id = 3, Number = "305", ComputerCount = 12, IsAvailable = false }
        };
    
            public List<Room> GetRooms()
            {
                return rooms;
            }
    }
}
