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
    public class CarRepository : Repository<Car, Guid>, ICarRepository
    {
        public DatabaseContext DatabaseContext()
        {
            return _dbContext as DatabaseContext;
        }

        public CarRepository(DbContext context) : base(context)
        {
        }
    }
}
