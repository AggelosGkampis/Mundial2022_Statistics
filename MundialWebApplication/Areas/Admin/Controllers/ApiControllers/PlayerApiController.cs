using Entities;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace MundialWebApplication.Areas.Admin.Controllers.ApiControllers
{
    public class PlayerApiController : Controller
    {
        DAL.ApplicationDbContext db = new DAL.ApplicationDbContext();
        UnitOfWork unit;
        public PlayerApiController()
        {
            unit = new UnitOfWork(db);  
        }

        [HttpGet]
        public ActionResult GetNames()
        {
            var names = unit.Players.GetAll().Select(x=> new {x.Name});

            return Json(names, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetPlayers()
        {
            var players = unit.Players.GetAll();

            return Json(players, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]

        public ActionResult CreatePlayer(Player player)
        {
            if (ModelState.IsValid)
            {
                unit.Players.Insert(player);
                unit.Complete();
                return Json(player, JsonRequestBehavior.AllowGet);

                //return new HttpStatusCodeResult(HttpStatusCode.OK);   
                //return new HttpStatusCodeResult(HttpStatusCode.Created);     // TO SHOW THAT EVERYTHING WORKED
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpDelete]

        public ActionResult DeletePlayerById(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var player = unit.Players.GetById(id);

            if (player is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            unit.Players.Delete(id);
            unit.Complete();
            return Json(player, JsonRequestBehavior.AllowGet);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unit.Dispose();  
            }

            base.Dispose(disposing);    
        }
    }
}
