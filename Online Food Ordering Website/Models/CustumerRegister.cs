using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_Website.Models
{
    public class CustumerRegister
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int cu_id { get; set; }




        [Display(Name = "Name")]
        public string cu_name { get; set; }


        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string cu_email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string cu_password { get; set; }


        [Display(Name = "Re-Type Password")]
        [DataType(DataType.Password)]
        public string cu_re_password { get; set; }
    }
}