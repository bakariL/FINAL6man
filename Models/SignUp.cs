using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TV5.Models
{
    public class SignUp
    {
        [Key]
        public int UserID { get; set; }

        
        [Required(ErrorMessage = "Email is required,")]
        public string Email { get; set; }


    }
}