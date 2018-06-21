using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiService.Entities.Models;
using TaxiService.Web.DTOs;

namespace TaxiService.Web.App_Start.ProfileMapings
{
    public class MapCarProfile : Profile
    {
        public MapCarProfile()
        {
            CreateMap<Car, CarDTO>();

            CreateMap<CarDTO, Car>();
        }
    }
}