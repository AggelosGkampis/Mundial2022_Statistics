using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeamRepository
    {
        ApplicationDbContext db;

        public TeamRepository(ApplicationDbContext context)
        {
            db = context;
        }
    }
}
