using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundialWebApplication.Areas.Admin.Controllers
{
    public class NobelController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}