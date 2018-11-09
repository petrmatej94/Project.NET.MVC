using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.NET.MVC.Models
{
    public class User
    {
        [Display(Name = "Login Name")]
        [Required(ErrorMessage = "Login must be filled in")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password must be filled in")]
        public string Password { get; set; }
    }
}
