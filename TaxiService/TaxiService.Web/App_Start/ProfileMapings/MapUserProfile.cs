using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiService.Entities.Models;
using TaxiService.Web.DTOs;

namespace TaxiService.Web.App_Start.ProfileMapings
{
    public class MapUserProfile : Profile
    {
        public MapUserProfile()
        {
            CreateMap<User, UserDTO>();

            CreateMap<UserDTO, UberDriver>();
        }
    }
}