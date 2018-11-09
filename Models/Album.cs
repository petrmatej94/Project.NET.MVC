using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.NET.MVC.Models
{
    public class Album
    {
        public int ID { get; set; }


        [Required(ErrorMessage = "Name must be filled in")]
        [Display(Name = "Album Name")]
        [StringLength(30, ErrorMessage = "Max 30 chars")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Author must be filled in")]
        [Display(Name = "Author Name")]
        [StringLength(30, ErrorMessage = "Max 30 chars")]
        public string Author { get; set; }


        [Required(ErrorMessage = "Year must be filled in")]
        [Display(Name = "Year")]
        [Range(1800, 2100, ErrorMessage = "Year must be between 1800 - 2100")]
        public int Year { get; set; }
    }
}
