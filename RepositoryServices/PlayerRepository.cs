using DAL;
using Entities;
using Entities.Enums;
using RepositoryServices.Core;
using RepositoryServices.Core.Repositories;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Player> GetAllPlayersByPosition()
        {
            return table.OrderBy(p => p.Position).ToList();            
        }
    }
}
