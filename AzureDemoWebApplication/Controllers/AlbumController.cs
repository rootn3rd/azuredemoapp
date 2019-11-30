using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDemoWebApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace AzureDemoWebApplication.Controllers
{
    public class AlbumController : Controller
    {
        private readonly MusicStoreContext musicStoreContext;

        public AlbumController(MusicStoreContext musicStoreContext)
        {
            this.musicStoreContext = musicStoreContext;
        }
        public IActionResult Index()
        {

            return View(musicStoreContext.GetAllAlbums());
        }
    }
}