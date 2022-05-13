using AutoMapper;
using FortRobotics.API.Data;
using FortRobotics.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortRobotics.API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Cities, CityModel>().ReverseMap();
        }
    }
}
