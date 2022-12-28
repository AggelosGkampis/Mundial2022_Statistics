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

namespace RepositoryServices.Persistance.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext context) : base(context)
        {

        }

        public void AddPersons(IEnumerable<Person> persons)
        {
            table.AddRange(persons);
        }
    }
}
