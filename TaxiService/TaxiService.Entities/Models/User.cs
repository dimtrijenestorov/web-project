using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities.Shared;

namespace TaxiService.Entities.Models
{
    public abstract class User
    {
        [Key]
        public virtual string Username { get; set; }
        [Required]
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        [Required]
        public virtual string Sex { get; set; }
        [Required]
        public virtual string JMBG { get; set; }
        public virtual string PhoneNumber { get; set; }
        [Required]
        public virtual string EMail { get; set; }
        [Required]
        public virtual string Role { get; set; }
        [Required]
        public virtual Guid RideId { get; set; }
        [ForeignKey("RideId")]
        public virtual Ride Ride { get; set; }
    }
}
