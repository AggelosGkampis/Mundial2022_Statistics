using Antlr.Runtime.Misc;
using AuthenticationWebApp.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationWebApp.Controllers
{
    
    public class HomeController : Controller
    {

        private DAL.ApplicationDbContext mundialDb = new DAL.ApplicationDbContext(); 
        private AuthenticationWebApp.Models.ApplicationDbContext userDb = new AuthenticationWebApp.Models.ApplicationDbContext(); 


        public ActionResult Index()
        {
            var favorites = mundialDb.UserFavPlayers.ToList();

            var playerNames = from favorite in favorites
                          join player in mundialDb.Players on favorite.PlayerId equals player.PlayerId
                          //where favorite.PlayerId == player.PlayerId
                          select new { name = player.Name };

            var usernames = from favorite in favorites
                            join user in userDb.Users on favorite.UserId equals user.Id                            
                            select new {username = user.UserName};

            var groups = from favorite in favorites
                         group favorite by favorite.UserId into lista
                         select lista;

            var groups2 = from favorite in favorites
                          group favorite by favorite.UserId into lista
                          select new
                          {
                              paixtes = lista.Count()
                          };

            return Json(groups2, JsonRequestBehavior.AllowGet);
        }

       
        public ActionResult About()
        {
            if (User.IsInRole("Admin"))
            {
                return Content("Hello Administrator ! ! !");
            }
            else
            {
                return Content("Hello Random");
            }

            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}