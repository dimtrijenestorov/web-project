using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Web.DTOs
{
    public class UserDTO : DTO
    {
        public UserDTO()
        {
            Banned = false;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string JMBG { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Role { get; set; }
        public string RideId { get; set; }
        public bool Banned { get; set; }

        public List<RideDTO> CustomersRides { get; set; }
        public List<RideDTO> DispetchersRides { get; set; }
        public List<RideDTO> UbersRides { get; set; }
        public List<CommentDTO> Comments { get; set; }

        public LocationDTO UbersLocation { get; set; }
        public CarDTO UbersCar { get; set; }
    }
}