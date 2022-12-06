using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MundialWebApplication.Areas.Customer.Controllers
{
    public class PlayerController : Controller
    {
     
        // GET: Customer/Player
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
      
    }
}