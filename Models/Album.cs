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


        [Display(ResourceType = typeof(Project.NET.MVC.Resources.Translation), Name = "AlbumName", Prompt = "EnterAlbumName")]
        [Required(ErrorMessage = "Name must be filled in")]
        [StringLength(30, ErrorMessage = "Max 30 chars")]
        public string Name { get; set; }


        [Display(ResourceType = typeof(Project.NET.MVC.Resources.Translation), Name = "Author", Prompt = "EnterAuthor")]
        [Required(ErrorMessage = "Author must be filled in")]
        [StringLength(30, ErrorMessage = "Max 30 chars")]
        public string Author { get; set; }


        [Display(ResourceType = typeof(Project.NET.MVC.Resources.Translation), Name = "Year", Prompt = "EnterYear")]
        [Required(ErrorMessage = "Year must be filled in")]
        [Range(1800, 2100, ErrorMessage = "Year must be between 1800 - 2100")]
        public int Year { get; set; }
    }
}
