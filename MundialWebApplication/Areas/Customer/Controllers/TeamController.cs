using Entities;
using MundialWebApplication.Areas.Customer.ViewModels;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MundialWebApplication.Areas.Customer.Controllers
{
    public class TeamController : Controller
    {
        DAL.ApplicationDbContext db = new DAL.ApplicationDbContext();
        UnitOfWork unit;

        public TeamController()
        {
            unit = new UnitOfWork(db);
        }


        // GET: Customer/Team
        public ActionResult Index()
        {
            TeamIndexViewModel vm = new TeamIndexViewModel()
            {
                BestTeams = unit.Teams.GetBestTeams(),
                MostGoalsScored = unit.Teams.GetMostGoalsScored(),
                TopWinners = unit.Teams.GetTopWinners(5),
            };

            return View(vm);
        }

        public ActionResult Details()
        {
            return View();
        }

        [ChildActionOnly]                      // Trexei mono mesa ap thn html και φτιάχνω ουσιαστικά ένα reusable component
        public ActionResult DisplayTeamCards(List<Team> teams, string headerMessage)
        {
            DisplayTeamCardsViewModel vm = new DisplayTeamCardsViewModel()
            {
                Teams = teams,
                HeaderTitle = headerMessage
            };

            return View(vm);
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