using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities;
using TaxiService.Entities.Models;
using TaxiService.MSSQLRepository.ModelRepositoryInterfaces;

namespace TaxiService.MSSQLRepository.ModelRepositories
{
    public class UserRepository : Repository<User,string>, IUserRepository
    {
        public DatabaseContext DatabaseContext()
        {
            return _dbContext as DatabaseContext;
        }

        public UserRepository(DatabaseContext context) : base(context) { }
        
    }
}
