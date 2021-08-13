using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace TaskAllocation.LookupEntities
{
    public class LookupTaskStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int TaskStatusId { get; set; }

        [Required]
        public string TaskStatus { get; set; }
        public virtual ICollection<Entities.Task> Tasks { get; set; }
    }
}
