using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities.Models.RideStates;
using TaxiService.Entities.Shared;

namespace TaxiService.Entities.Models
{
    public class Ride
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public virtual DateTime Timestamp { get; set; }
        [Required]
        public virtual Guid ArivalId { get; set; }
        [ForeignKey("ArivalId")]
        public virtual Location ArivalSpot { get; set; }
        [Required]
        public virtual EnumCarType CarType { get; set; }
        [Required]
        public virtual Guid DestinationId { get; set; }
        [ForeignKey("DestinationId")]
        public virtual Location DestinationSpot { get; set; } // ??? is it even legit?
        
        //Uber, client props left out becouse they will be referenced from User table

        public virtual float Total { get; set; }
        public virtual string Comment { get; set; }
        public virtual string State { get; set; }

        // State-machine
        private RideState _state;

        public Ride()
        {
            _state = new CreatedState(this);
        }
    }
}
