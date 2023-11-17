using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.Domain.Models
{
    public class Reminder : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}
