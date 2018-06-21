using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Web.DTOs
{
    public class LocationDTO : DTO
    {
        public Guid Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public AddressDTO Address { get; set; }

        public List<UserDTO> UbersOnLocation { get; set; }
        public List<RideDTO> RidesOnArivalSpot { get; set; }
        public List<RideDTO> RidesOnDestinationSpot { get; set; }

    }
}