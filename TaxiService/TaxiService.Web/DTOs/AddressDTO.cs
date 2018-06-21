using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Web.DTOs
{
    public class AddressDTO : DTO
    {
        public Guid Id { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public int PostalNumber { get; set; }
    }
}