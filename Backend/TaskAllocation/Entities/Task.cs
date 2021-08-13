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
    public class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int TaskId { get; set; }
        [Required]
        [MaxLength(100)]
        public string TaskName { get; set; }
        public int UserTypeId { get; set; }
        public virtual LookupUserType LookupUserType { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public float EstimatedTime { get; set; }
        public float ActualEffort { get; set; }
        public int TaskStatusId { get; set; }
        public virtual LookupTaskStatus LookupTaskStatus { get; set; }


    }
}
