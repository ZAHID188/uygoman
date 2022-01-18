using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uygoman.Models
{
    public class CompanyReg
    {

        //{Company name, company arabic name, Brand name,email,phone number, contact person,upload company registration file}
        [Key]
        public int ID { get; set; }

        [DisplayName(" Company Name:")]
        [Required]
        public string CmpName { get; set; }
        
        [DisplayName("Company Arabic name:")]
        public string CmpArabicName { get; set; }

        [DisplayName("Company Brand name:")]
        public string CmpBrandName { get; set; }

        [DisplayName("Email:")]
        [Required]
        public string Email { get; set; }

        [DisplayName("Phone number:")]
        [Required]
        public string Phone { get; set; }

        [DisplayName("Contact person:")]
        public string ContactPerson { get; set; }

        [DisplayName("Upload Registration Documents:")]
        public string Upload { get; set; }







    }
}
