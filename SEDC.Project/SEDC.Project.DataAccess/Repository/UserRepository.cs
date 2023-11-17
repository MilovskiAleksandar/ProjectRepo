using Microsoft.EntityFrameworkCore;
using SEDC.Project.DataAccess.Interfaces;
using SEDC.Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectDbContext _projectDbContext;
        public UserRepository(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public void Add(User entity)
        {
            _projectDbContext.Users.Add(entity);
            _projectDbContext.SaveChanges();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _projectDbContext.Users
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
