using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiService.Web.DTOs
{
    public class CommentDTO : DTO
    {
        public string Id { get; set; }
        public RideDTO Ride { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Timestamp { get; set; }
        public string Content { get; set; }
        [Range(0, 5)]
        public int Quality { get; set; }
        public UserDTO User { get; set; }
    }
}