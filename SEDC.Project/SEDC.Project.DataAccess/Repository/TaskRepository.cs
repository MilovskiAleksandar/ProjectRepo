using SEDC.Project.DataAccess.Interfaces;
using SEDC.Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.DataAccess.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ProjectDbContext _context;
        public TaskRepository(ProjectDbContext projectDbContext)
        {
            _context = projectDbContext;
        }

        public void Add(Tasks entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tasks entity)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tasks GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tasks entity)
        {
            throw new NotImplementedException();
        }
    }
}
