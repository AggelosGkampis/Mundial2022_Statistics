using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices
{
    public class PlayerRepository
    {
        ApplicationDbContext db;

        public PlayerRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public List<Player> GetAll()
        {
            throw new NotImplementedException();    
        }

        public Player GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Player player)
        {
            throw new NotImplementedException();
        }

        public void Update(Player player)
        {
            throw new NotImplementedException();
        }

        public void Delete(Player player)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
