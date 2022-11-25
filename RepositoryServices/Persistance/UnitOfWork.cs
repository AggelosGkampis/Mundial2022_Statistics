using DAL;
using RepositoryServices.Core;
using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            context = dbContext;
            Teams = new TeamRepository(context);
            Players = new PlayerRepository(context);
            Coaches = new CoachRepository(context);
        }

        public ITeamRepository Teams { get; private set; }

        public IPlayerRepository Players { get; private set; }

        public ICoachRepository Coaches { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
