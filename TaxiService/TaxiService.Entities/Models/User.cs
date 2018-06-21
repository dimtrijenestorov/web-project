using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaxiService.Entities.Shared;

namespace TaxiService.Entities.Models
{
    public abstract class User
    {
        public User()
        {
            CustomerRides = new HashSet<Ride>();
            DispetcherRides = new HashSet<Ride>();
            UberDriverRides = new HashSet<Ride>();
            UsersComments = new HashSet<Comment>();
        }

        [Key]
        public virtual string Username { get; set; }
        [Required]
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Sex { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string PhoneNumber { get; set; }
        [Required]
        public virtual string EMail { get; set; }
        [Required]
        public virtual string Role { get; set; }
        public virtual string RideId { get; set; }
        [ForeignKey("RideId")]
        public virtual Ride Ride { get; set; }
        [Required]
        public virtual bool Banned { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Ride> CustomerRides { get; set; }
        [InverseProperty("Dispetcher")]
        public virtual ICollection<Ride> DispetcherRides { get; set; }
        [InverseProperty("UberDriver")]
        public virtual ICollection<Ride> UberDriverRides { get; set; }
        public virtual ICollection<Comment> UsersComments { get; set; }
    }
}
