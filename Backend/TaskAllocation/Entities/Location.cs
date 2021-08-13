using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAllocation.Entities
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int LocationId { get; set; }
        [Required]
        [MaxLength(50)]
        public string LocationName { get; set; }

      //  public string ShortName { get; set; }

        public int ConversionId { get; set; }
        public virtual Conversion Conversion { get; set; }
    }
}
