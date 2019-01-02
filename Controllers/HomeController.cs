using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.NET.MVC.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;


namespace Project.NET.MVC.Controllers
{
    public class HomeController : Controller
    {
        private AlbumService albumService;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(AlbumService albumService, IStringLocalizer<HomeController> localizer)
        {
            this.albumService = albumService;
            this._localizer = localizer;
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if(user != null && user.UserName != null && user.Password != null)
            {
                if (user.UserName.Length <= 3 || user.UserName.Length >= 30)
                {
                    ModelState.AddModelError("UserName", Project.NET.MVC.Resources.Translation.LengthError);
                }
            }


            if (ModelState.IsValid)
            {
                if (user.UserName == "petr" && user.Password == "petr" && ModelState.IsValid)
                {
                    HttpContext.Session.SetString("user", user.UserName);

                    return RedirectToAction("AlbumList", "Home");
                }
                else
                {
                    ModelState.AddModelError("UserName", Project.NET.MVC.Resources.Translation.WrongDetails);
                }
            }

            return View(user);
        }


        [HttpGet]
        public IActionResult AlbumList()
        {
            ViewBag.currentUser = HttpContext.Session.GetString("user");
            ViewBag.albums = this.albumService.AlbumsList();

            return View();
        }

        [HttpPost]
        public IActionResult AlbumList(Album album)
        {
            if (album != null)
            {
                if(album.ID == 0)
                {
                    albumService.AddNewAlbum(album);
                }
                else
                {
                    albumService.DeleteAlbum(album.ID);
                }
            }

            ViewBag.currentUser = HttpContext.Session.GetString("user");
            ViewBag.albums = this.albumService.AlbumsList();

            return View();
        }


        public IActionResult AlbumListUpdate(Album album)
        {
            albumService.UpdateAlbum(album);

            ViewBag.currentUser = HttpContext.Session.GetString("user");
            ViewBag.albums = this.albumService.AlbumsList();
            
            return RedirectToAction("AlbumList", "Home");
        }



        public IActionResult Detail(int id)
        {
            ViewBag.currentUser = HttpContext.Session.GetString("user");
            ViewBag.album = albumService.FindById(id);
            
            return View();
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
