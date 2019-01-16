using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicePacket.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryID { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string Name { get; set; }
        public Nullable<long> ParentID { get; set; }
        public virtual Category Parent{ get; set;}

        public int Code { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        
    }
}
