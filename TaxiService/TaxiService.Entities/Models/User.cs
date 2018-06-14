using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities.Shared;

namespace TaxiService.Entities.Models
{
    public abstract class User
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name="username")]
        [StringLength(50, ErrorMessage ="Username cannot be longer than 50 characters!")]
        public virtual string Username { get; set; }
        [Required]
        [Display(Name = "password")]
        public virtual string Password { get; set; }
        [Required]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters!")]
        public virtual string Name { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters!")]
        public virtual string LastName { get; set; }
        public virtual EnumSex Sex { get; set; }
        public virtual string JMBG { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        [StringLength(20, ErrorMessage = "Phone number cannot be longer than 20 characters!")]
        public virtual string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "E-mail")]
        [StringLength(50, ErrorMessage = "E-mail cannot be longer than 50 characters!")]
        public virtual string EMail { get; set; }
        public virtual EnumRole Role { get; set; }
        [Required]
        public virtual Guid RideID { get; set; }
        [ForeignKey("RideId")]
        public virtual Ride Ride { get; set; }
    }
}
