using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.MSSQLRepository.ModelRepositoryInterfaces;

namespace TaxiService.MSSQLRepository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IRideRepository RideRepository { get; }
        ILocationRepositrory LocationRepository { get; }
        IAddressRepository AddressRepository { get; }
        ICarRepository CarRepository { get; }
        ICommentRepository CommentRepository { get; }
        int Complete();
    }
}
