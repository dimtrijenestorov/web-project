using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.MSSQLRepository.ModelRepositories;
using TaxiService.MSSQLRepository.ModelRepositoryInterfaces;
using Unity.Attributes;

namespace TaxiService.MSSQLRepository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _dbContext;

        public UnitOfWork(DatabaseContext context)
        {
            _dbContext = context;
        }

        [Dependency]
        public virtual IUserRepository UserRepository { get; private set; }
        [Dependency]
        public virtual IRideRepository RideRepository { get; private set; }
        [Dependency]
        public virtual ILocationRepositrory LocationRepository { get; private set; }
        [Dependency]
        public virtual IAddressRepository AddressRepository { get; private set; }
        [Dependency]
        public virtual ICarRepository CarRepository { get; private set; }
        [Dependency]
        public virtual ICommentRepository CommentRepository { get; private set; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
