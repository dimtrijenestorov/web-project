using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.MSSQLRepository.ModelRepositories;
using TaxiService.MSSQLRepository.ModelRepositoryInterfaces;

namespace TaxiService.MSSQLRepository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _dbContext;

        public UnitOfWork(DatabaseContext context)
        {
            _dbContext = context;

            UserRepository = new UserRepository(_dbContext);
            RideRepository = new RideRepository(_dbContext);
            LocationRepository = new LocationRepository(_dbContext);
            AddressRepository = new AddressRepository(_dbContext);
            CarRepository = new CarRepository(_dbContext);
            CommentRepository = new CommentRepository(_dbContext);
        }

        public virtual IUserRepository UserRepository { get; private set; }
        public virtual IRideRepository RideRepository { get; private set; }
        public virtual ILocationRepositrory LocationRepository { get; private set; }
        public virtual IAddressRepository AddressRepository { get; private set; }
        public virtual ICarRepository CarRepository { get; private set; }
        public virtual ICommentRepository CommentRepository { get; private set; }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
