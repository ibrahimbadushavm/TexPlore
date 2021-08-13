using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAllocation.LookupEntities
{
    public class LookupBuildType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int BuildTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string BuildType { get; set; }
    }
}
