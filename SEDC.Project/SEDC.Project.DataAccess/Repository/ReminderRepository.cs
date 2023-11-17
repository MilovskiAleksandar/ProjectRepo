using SEDC.Project.DataAccess.Interfaces;
using SEDC.Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.DataAccess.Repository
{
    public class ReminderRepository : IReminderRepository
    {
        private readonly ProjectDbContext _projectDbContext;
        public ReminderRepository(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }
        public void Add(Reminder entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Reminder entity)
        {
            throw new NotImplementedException();
        }

        public List<Reminder> GetAll()
        {
            throw new NotImplementedException();
        }

        public Reminder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Reminder entity)
        {
            throw new NotImplementedException();
        }
    }
}
