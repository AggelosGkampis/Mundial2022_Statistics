using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class CoachRepository
    {
        ApplicationDbContext db;

        public CoachRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Coach> GetAll()
        {
            throw new NotImplementedException();    
        }

        public Coach GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Coach coach)
        {
            throw new NotImplementedException();
        }

        public void Update(Coach coach)
        {
            throw new NotImplementedException();
        }

        public void Delete(Coach coach)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
