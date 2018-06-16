using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public virtual string StreetName { get; set; }
        [Required]
        public virtual int StreetNumber { get; set; }
        [Required]
        public virtual string City { get; set; }
        [Required]
        public virtual int PostNumber { get; set; }
        
    }
}
