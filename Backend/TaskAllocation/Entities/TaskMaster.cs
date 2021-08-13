using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAllocation.Entities
{
    public class TaskMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int TaskMasterId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TaskName { get; set; }
        public int IsPlannerStart { get; set; }
    }
}
