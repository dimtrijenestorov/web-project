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
    public class CommentRepository : Repository<Comment, Guid>, ICommentRepository
    {
        public DatabaseContext DatabaseContext()
        {
            return _dbContext as DatabaseContext;
        }

        public CommentRepository(DbContext context) : base(context)
        {
        }
    }
}
