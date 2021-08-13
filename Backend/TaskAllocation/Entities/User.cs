using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAllocation.LookupEntities;

namespace TaskAllocation.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
       
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Password { get; set; }

        public int UserTypeId { get; set; }
        public virtual LookupUserType LookupUserType { get; set; }

        public int ProfileId { get; set; }
        public virtual LookupProfile LookupProfile { get; set; }
       
        [Timestamp]
        public byte[] RowVersionStamp { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
