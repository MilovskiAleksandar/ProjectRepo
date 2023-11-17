using SEDC.Project.Domain.Models;
using SEDC.Project.DTOS.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.Services.Interfaces
{
    public interface IUserService
    {
        UsersDto GetUser(int id);
    }
}
