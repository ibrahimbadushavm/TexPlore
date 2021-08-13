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
    public class LookupProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int ProfileId { get; set; }
        [Required]
        public string ProfileName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
