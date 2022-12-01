using DAL;
using Entities;
using RepositoryServices.Core;
using RepositoryServices.Core.Repositories;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance.Repositories
{
    public class CoachRepository : GenericRepository<Coach>, ICoachRepository
    {
        public CoachRepository(ApplicationDbContext context) : base (context)
        {

        }

        public IEnumerable<Coach> GetAllCoachesByNameAsc()
        {
            return table.OrderBy(x => x.Name).ToList();
        }
    }
}
