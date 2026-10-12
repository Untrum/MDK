using ClassroomBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomBooking.Services
{
    internal class BookingService
    {
        private readonly List<Booking> bookings = new List<Booking>();

        public bool AddBooking(Booking booking)
        {
            bool conflict = bookings.Any(x =>
                x.RoomId == booking.RoomId &&
                x.Date.Date == booking.Date.Date &&
                x.StartTime < booking.EndTime &&
                booking.StartTime < x.EndTime);

            if (conflict)
                return false;

            booking.Id = bookings.Count + 1;
            bookings.Add(booking);
            return true;
        }

        public List<Booking> GetBookings()
        {
            return bookings;
        }
    }
}
