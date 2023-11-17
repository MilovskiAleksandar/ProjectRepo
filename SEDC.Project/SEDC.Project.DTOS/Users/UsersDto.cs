﻿using SEDC.Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.DTOS.Users
{
    public class UsersDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public List<Tasks> TasksList { get; set; } = new List<Tasks>();
        public List<Reminder> Reminders { get; set; } = new List<Reminder>();
    }
}
