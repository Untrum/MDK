using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomBooking.Models
{
    internal class Room
    {
        public int Id { get; set; }
        public string Number { get; set; } = "";
        public int ComputerCount { get; set; }
        public bool IsAvailable { get; set; } 
    }
}
