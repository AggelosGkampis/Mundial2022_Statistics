using Entities;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace MundialWebApplication.Areas.Admin.Controllers.ApiControllers
{
    public class PlayerApiController : BaseClassController
    {
       

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

        [HttpPut]
        public ActionResult EditPlayer ( int? id,Player player)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var pl = unit.Players.GetById(id);
            
            if (pl is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            // Mapping 

            pl.Name= player.Name;
            pl.Overall= player.Overall;
            unit.Players.Update(pl);
            unit.Complete();
            return  Json(pl, JsonRequestBehavior.AllowGet);
        }

     
    }
}
