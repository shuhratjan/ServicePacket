using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePacket.Models
{
    public class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ServiceID { get; set; }

        [Required]
        [StringLength(500,MinimumLength =3)]
        [Display(Name= "Название услуги")]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name="Цена")]
        public decimal Price { get; set; }
        public Nullable<long> CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}
