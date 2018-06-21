using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models
{
    public class Comment
    {
        [Key, ForeignKey("Ride")]
        public virtual string Id { get; set; }
        public virtual Ride Ride { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public virtual DateTime Timestamp { get; set; }
        [Required]
        public virtual string Content { get; set; }
        [Required]
        [Range(0, 5)]
        public virtual int Quality { get; set; }
        public virtual string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
