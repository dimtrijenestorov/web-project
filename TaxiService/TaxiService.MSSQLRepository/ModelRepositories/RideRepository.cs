using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities;
using TaxiService.Entities.Models;
using TaxiService.MSSQLRepository.ModelRepositoryInterfaces;

namespace TaxiService.MSSQLRepository.ModelRepositories
{
    public class RideRepository : Repository<Ride, Guid>, IRideRepository
    {
        public DatabaseContext DatabaseContext()
        {
            return _dbContext as DatabaseContext;
        }

        public RideRepository(DbContext context) : base(context)
        {
        }
    }
}
