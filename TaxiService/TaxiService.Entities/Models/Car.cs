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
        [Display(Name = "Year of production")]
        public virtual int YearOfProduction { get; set; }
        [Required]
        [Display(Name = "Registration number")]
        public virtual string RegistrationNumber { get; set; }
        [Required]
        [Display(Name = "Taxi number")]
        public virtual string TaxiNumber { get; set; }
        [Required]
        [Display(Name = "Car type")]
        public virtual string CarType { get; set; }
    }
}
