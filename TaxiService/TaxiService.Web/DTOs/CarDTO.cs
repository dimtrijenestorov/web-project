using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Web.DTOs
{
    public class CarDTO : DTO
    {
        public string Id { get; set; }
        public UserDTO Uber { get; set; }
        public int YearOfProduction { get; set; }
        public string RegistrationNumber { get; set; }
        public string TaxiNumber { get; set; }
        public string CarType { get; set; }
    }
}