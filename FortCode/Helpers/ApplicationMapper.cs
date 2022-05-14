using AutoMapper;
using FortCode.Data;
using FortCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortCode.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Cities, CityModel>().ReverseMap();
        }
    }
}
