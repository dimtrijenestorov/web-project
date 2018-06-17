using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models
{
    public class Customer : User
    {
        public virtual ICollection<Comment> UsersComments { get; set; }
    }
}
