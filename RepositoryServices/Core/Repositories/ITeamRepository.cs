using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core.Repositories
{
    public interface ITeamRepository : IGenericRepository<Team>
    {
        IEnumerable<Team> GetTeamsOrderByAscending();

        IEnumerable<Team> GetTeamsOrderByDescending();

        IEnumerable<Team> GetBestTeams();

        IEnumerable<Team> GetTopWinners(int count);

        IEnumerable<Team> GetMostGoalsScored();
    }
}
