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
            UbersOnLocation = new HashSet<UberDriver>();
            RidesOnArivalSpot = new HashSet<Ride>();
            RidesOnDestinationSpot = new HashSet<Ride>();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public virtual double X { get; set; }
        [Required]
        public virtual double Y { get; set; }
        [Required]
        public virtual Guid AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        [InverseProperty("UbersLocation")]
        public virtual ICollection<UberDriver> UbersOnLocation { get; set; }
        [InverseProperty("ArivalSpot")]
        public virtual ICollection<Ride> RidesOnArivalSpot { get; set; }
        [InverseProperty("DestinationSpot")]
        public virtual ICollection<Ride> RidesOnDestinationSpot { get; set; }
    }
}
