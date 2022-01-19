using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uygoman.Models
{
    public class CrKey
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        [DisplayName("Create Keys:")]
        public string Keys { get; set; }

        [ForeignKey("Prod")]
        [DisplayName("Product Name:")]
        public string Product_Name { get; set; }

        public virtual Product Prod { get; set; }
    }
}
