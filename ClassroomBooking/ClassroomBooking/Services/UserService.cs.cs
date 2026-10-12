using ClassroomBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomBooking.Services
{
    internal class UserService
    {
        private readonly List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Иван Петров", login = "petrov", Role = "Преподаватель"},
            new User { Id = 2, Name = "Анна Смирнова", login = "smirnova", Role = "Преподаватель"},
            new User { Id = 3, Name = "Администратор", login = "admin", Role = "Администратор"},
        };

        public List<User> GetUsers()
        {  
            return users; 
        }
    }
}
