﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MundialWebApplication.Areas.Customer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Customer/Home
        public ActionResult Index()
        {
            return Content("I am a customer");
        }
    }
}