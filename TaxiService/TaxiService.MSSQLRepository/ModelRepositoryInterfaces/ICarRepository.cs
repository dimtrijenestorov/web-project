using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities;
using TaxiService.Entities.Models;

namespace TaxiService.MSSQLRepository.ModelRepositoryInterfaces
{
    public interface ICarRepository : IRepository<Car, Guid>
    {
    }
}
