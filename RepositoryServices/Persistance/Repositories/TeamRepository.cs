using DAL;
using Entities;
using RepositoryServices.Core.Repositories;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance.Repositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
       
        public TeamRepository(ApplicationDbContext context) : base (context)
        {
           
        }

        public IEnumerable<Team> GetBestTeams()
        {
            return table.OrderByDescending(x => x.Rating).Take(5).ToList();
        }

        public IEnumerable<Team> GetMostGoalsScored()
        {
            return table.OrderByDescending(x => x.GoalsScored).Take(5).ToList();
        }

        public IEnumerable<Team> GetTeamsOrderByAscending()
        {
            return table.OrderBy(x => x.Name).ToList();
        }

        public IEnumerable<Team> GetTeamsOrderByDescending()
        {
            return table.OrderByDescending(x => x.Name).ToList();
        }

        public IEnumerable<Team> GetTopWinners(int count)
        {
            return table.OrderByDescending(x => x.TimesWonWorldCup).Take(count).ToList();
        }

    }
}
