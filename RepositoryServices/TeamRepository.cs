using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class TeamRepository
    {
        ApplicationDbContext db;

        public TeamRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Team> GetAll()
        {
            throw new NotImplementedException();    
        }

        public Team GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Team team)
        {
            throw new NotImplementedException();
        }

        public void Update(Team team)
        {
            throw new NotImplementedException();
        }

        public void Delete(Team team)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
