using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities.Models;

namespace TaxiService.MSSQLRepository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<Ride> RideSet { get; set; }
        public virtual DbSet<Location> LocationSet { get; set; }
        public virtual DbSet<Address> AddressSet { get; set; }
        public virtual DbSet<Car> CarSet { get; set; }
        public virtual DbSet<Comment> CommentSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}
