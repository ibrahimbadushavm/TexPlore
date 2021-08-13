using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAllocation.Entities;

namespace TaskAllocation.LookupEntities
{
    public class LookupUserType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int UserTypeId { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Entities.Task> Tasks { get; set; }
    }
}
