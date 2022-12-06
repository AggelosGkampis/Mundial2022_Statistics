using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundialWebApplication.Areas.Customer.ViewModels
{
    public class DisplayTeamCardsViewModel
    {
        public IEnumerable<Team> Teams { get; set; }

        public string HeaderTitle { get; set; }
    }
}