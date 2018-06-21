using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiService.Web.DTOs
{
    public class RideDTO : DTO
    {
        public string Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Timestamp { get; set; }
        public LocationDTO ArivalSpot { get; set; }
        public LocationDTO DestinationSpot { get; set; }
        public string CarType { get; set; }
        public UserDTO Customer { get; set; }
        public UserDTO Dispetcher { get; set; }
        public UserDTO Uber { get; set; }
        public CommentDTO Comment { get; set; }
        public float Total { get; set; }
        public string State { get; set; }
    }
}