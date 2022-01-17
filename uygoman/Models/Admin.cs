using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uygoman.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("User ID:")]
        [Required]
        public string UserID { get; set; }
        [Required]
        [DisplayName("Password:")]
        //[Range(0,int.MaxValue,ErrorMessage="Password should be greater than 8 less than 20")]
        public string Password { get; set; }

    }
}
