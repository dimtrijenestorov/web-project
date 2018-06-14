using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models
{
    public class UberDriver : User
    {
        [Required]
        public virtual Guid LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }
        [Required]
        public virtual Guid CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}
