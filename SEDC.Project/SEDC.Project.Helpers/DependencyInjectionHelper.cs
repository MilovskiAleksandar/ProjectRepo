using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SEDC.Project.DataAccess;
using SEDC.Project.DataAccess.Interfaces;
using SEDC.Project.DataAccess.Repository;
using SEDC.Project.Domain.Models;
using SEDC.Project.Services.Implementations;
using SEDC.Project.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services)
        {
            services.AddDbContext<ProjectDbContext>(x => x.UseSqlServer("Server=.\\;Database=ProjectDb;Trusted_Connection=True;TrustServerCertificate=True"));
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IReminderService, ReminderService>();
            services.AddTransient<ITaskService, TaskService>();
        
        }

        public static void InjectRepositories(IServiceCollection repositories)
        {
            repositories.AddTransient<IUserRepository, UserRepository>();
            repositories.AddTransient<IReminderRepository, ReminderRepository>();
            repositories.AddTransient<ITaskRepository, TaskRepository>();
        }
    }
}
