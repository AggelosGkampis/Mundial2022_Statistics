using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundialWebApplication.Areas.Customer.ViewModels
{
    public class TeamIndexViewModel
    {
        public IEnumerable<Team> BestTeams { get; set; }
        public IEnumerable<Team> TopWinners { get; set; }
        public IEnumerable<Team> MostGoalsScored { get; set; }


    }
}