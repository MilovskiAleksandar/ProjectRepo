using SEDC.Project.DataAccess.Interfaces;
using SEDC.Project.Domain.Models;
using SEDC.Project.DTOS.Users;
using SEDC.Project.Mappers.UserMap;
using SEDC.Project.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UsersDto GetUser(int id)
        {
            User user = _userRepository.GetById(id);
            return user.ToUserDto();
        }
    }
}
