using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities.Models.RideStates;
using TaxiService.Entities.Shared;

namespace TaxiService.Entities.Models
{
    public class Ride
    {
        // State-machine
        private RideState _state;

        public Ride()
        {
            _state = new CreatedState(this);
        }

        [Key]
        public string Id { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public virtual DateTime Timestamp { get; set; }
        public virtual Guid ArivalId { get; set; }
        [ForeignKey("ArivalId")]
        public virtual Location ArivalSpot { get; set; }
        public virtual Guid DestinationId { get; set; }
        [ForeignKey("DestinationId")]
        public virtual Location DestinationSpot { get; set; }
        [Required]
        public virtual string CarType { get; set; }
        public virtual string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public virtual string DispetcherId { get; set; }
        [ForeignKey("DispetcherId")]
        public virtual Dispetcher Dispetcher { get; set; }
        public virtual string UberDriverId { get; set; }
        [ForeignKey("UberDriverId")]
        public virtual UberDriver UberDriver { get; set; }
        public virtual float Total { get; set; }
        public virtual Guid CommentId { get; set; }
        [ForeignKey("CommentId")]
        public virtual Comment Comment { get; set; }
        [Required]
        public virtual string State { get; set; }

        
    }
}
