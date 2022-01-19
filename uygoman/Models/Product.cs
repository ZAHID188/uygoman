using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uygoman.Models
{
    public class Product
    {
        
        
        
        [Key]
        [Required]
        [StringLength(30)]
        [DisplayName("Product Name:")]
        public string ProductName { get; set; }






    }
}
