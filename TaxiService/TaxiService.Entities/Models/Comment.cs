using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models
{
    public class Comment
    {
        [Key]
        public virtual Guid Id { get; set; }
        [Required]
        public virtual string Content { get; set; }
        [Required]
        public virtual int Quality { get; set; }
    }
}
