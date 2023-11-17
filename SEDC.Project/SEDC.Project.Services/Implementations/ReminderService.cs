﻿using SEDC.Project.DataAccess.Interfaces;
using SEDC.Project.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.Services.Implementations
{
    public class ReminderService : IReminderService
    {
        private readonly IReminderRepository _repository;
        public ReminderService(IReminderRepository repository)
        {
            _repository = repository;
        }
    }
}
