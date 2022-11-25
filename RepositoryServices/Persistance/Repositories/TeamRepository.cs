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

        public IEnumerable<Team> GetTeamsOrderByAscending()
        {
            return table.OrderBy(x => x.Name).ToList();
        }

        public IEnumerable<Team> GetTeamsOrderByDescending()
        {
            return table.OrderByDescending(x => x.Name).ToList();
        }
    }
}
