using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAllocation.Entities
{
    public class Conversion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int ConversionId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ConversionName { get; set; }
        [Required]
        public int DbGroupNo { get; set; }
        [Required]
        [MaxLength(100)]
        public string DbGroupName { get; set; }
        [Required]
        [MaxLength(10)]
        public string ConversionNo { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
