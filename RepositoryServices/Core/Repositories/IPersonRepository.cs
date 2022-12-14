using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core.Repositories
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
       void AddPersons(IEnumerable<Person> persons);
    }
}
