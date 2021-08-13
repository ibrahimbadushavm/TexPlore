using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAllocation.Entities
{
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        [Required]
        
        public int AccountId { get; set; }
        [Required]
        [MaxLength(100)]
        public string AccountName { get; set; }
       
        public string AccountShortName { get; set; }
        

        public virtual ICollection<Conversion> Conversions { get; set; }

    }
}
