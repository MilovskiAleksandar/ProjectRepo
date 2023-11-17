using SEDC.Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.DataAccess.Interfaces
{
    public interface ITaskRepository : IRepository<Domain.Models.Tasks>
    {
    }
}
