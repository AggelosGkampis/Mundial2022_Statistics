using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core.Repositories
{
    public interface IPlayerRepository : IGenericRepository<Player>
    {
        IEnumerable<Player> GetAllPlayersByPosition();

        IQueryable<IGrouping<Position, Player>> GetAllPlayersGroupedByPosition();
    }
}
