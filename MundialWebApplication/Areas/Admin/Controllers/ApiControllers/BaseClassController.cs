using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MundialWebApplication.Areas.Admin.Controllers.ApiControllers
{
    public class BaseClassController : Controller
    {
        protected DAL.ApplicationDbContext db = new DAL.ApplicationDbContext();
        protected UnitOfWork unit;
        public BaseClassController()
        {
            unit = new UnitOfWork(db);
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