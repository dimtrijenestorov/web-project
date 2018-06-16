using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models
{
    public class Car
    {
        [Key]
        public virtual Guid Id { get; set; }
        [Required]
        public virtual int YearOfProduction { get; set; }
        [Required]
        public virtual string RegistrationNumber { get; set; }
        [Required]
        public virtual string TaxiNumber { get; set; }
        [Required]
        public virtual string CarType { get; set; }
    }
}
