using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MundialWebApplication.Areas.Admin.Controllers
{
    public class TeamApiController : Controller
    {
        DAL.ApplicationDbContext db = new DAL.ApplicationDbContext();
        UnitOfWork unit;

        public TeamApiController()
        {
            unit = new UnitOfWork(db);
        }

        
        public ActionResult GetTeams()
        {
            var teams = unit.Teams.GetAll()
                .Select(x => new
                {
                    x.Name,
                    x.PhotoUrl,
                    x.Rating,
                    x.SquadSize
                });

            return Json(new {data = teams}, JsonRequestBehavior.AllowGet);

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);    
        }
    }
}