using SEDC.Project.Domain.Models;
using SEDC.Project.DTOS.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.Mappers.UserMap
{
    public static class UserMapper
    {
        public static UsersDto ToUserDto(this User user)
        {
            return new UsersDto
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                //TO DO
                Reminders = user.Reminders,
                TasksList = user.TasksList,

            };
        }
    }
}
