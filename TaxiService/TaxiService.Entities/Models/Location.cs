using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models
{
    public class Location
    {
        public Location()
        {
            UbersLocation = new HashSet<UberDriver>();
            RideArivalSpot = new HashSet<Ride>();
            RideDestinationSpot = new HashSet<Ride>();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public virtual float X { get; set; }
        [Required]
        public virtual float Y { get; set; }
        [Required]
        public virtual Guid AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        [InverseProperty("UbersLocation")]
        public virtual ICollection<UberDriver> UbersLocation { get; set; }
        [InverseProperty("ArivalSpot")]
        public virtual ICollection<Ride> RideArivalSpot { get; set; }
        [InverseProperty("DestinationSpot")]
        public virtual ICollection<Ride> RideDestinationSpot { get; set; }
    }
}
