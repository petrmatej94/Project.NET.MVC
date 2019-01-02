using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.NET.MVC.Models
{
    public class User
    {
        [Display(ResourceType = typeof(Project.NET.MVC.Resources.Translation), Name = "Login", Prompt = "LoginPlaceholder")]
        //[Required(ErrorMessage = "Login must be filled in")]
        [Required(ErrorMessageResourceType = (typeof(Project.NET.MVC.Resources.Translation)), ErrorMessageResourceName = "LoginErrorMessage")]
        public string UserName { get; set; }

        [Display(ResourceType = typeof(Project.NET.MVC.Resources.Translation), Name = "Password", Prompt = "PasswordPlaceholder")]
        [Required(ErrorMessageResourceType = (typeof(Project.NET.MVC.Resources.Translation)), ErrorMessageResourceName = "PasswordErrorMessage")]
        public string Password { get; set; }
    }
}
