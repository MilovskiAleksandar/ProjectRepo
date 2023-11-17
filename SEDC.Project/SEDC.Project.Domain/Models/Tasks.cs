using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.Domain.Models
{
    public class Tasks : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int ShortBreak { get; set; }
        public int LongBreak { get; set; }
        public int WorkTime { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}
