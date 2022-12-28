using Entities;
using Microsoft.AspNetCore.Mvc;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using ActionResult = System.Web.Mvc.ActionResult;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace MundialWebApplication.Areas.Admin.Controllers.ApiControllers
{
    public class PersonApiController : BaseClassController
    {
        //[HttpGet]
        //public ActionResult GetAllPersons()
        //{
        //    var persons = unit.Persons.GetAll();
        //    return Json(persons, JsonRequestBehavior.AllowGet);
        //}
        

        //[HttpPost]
        //public ActionResult CreatePersons(IEnumerable<Person> persons)
        //{
        //    unit.Persons.AddPersons(persons);
        //    unit.Complete();
        //    return new HttpStatusCodeResult(HttpStatusCode.OK);

        //}
    }
}
