using AutoMapper;
using FortRobotics.API.Data;
using FortRobotics.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortRobotics.API.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly FRContext _context;
        private readonly IMapper _mapper;

        public CityRepository(FRContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Cities>> GetAllCitiesAsync()
        {
            var records = await _context.CityModel.ToListAsync();
            return _mapper.Map<List<Cities>>(records);
        }

        public async Task<Cities> GetCityByIdAsync(int cityId)
        {
            var city = await _context.CityModel.FindAsync(cityId);
            return _mapper.Map<Cities>(city);
        }

        public async Task<int> AddCityAsync(CityModel cityModel)
        {
            _context.CityModel.Add(cityModel); ;
            await _context.SaveChangesAsync();

            return cityModel.IdCity;
        }

        public async Task UpdateCityAsync(int cityId, CityModel cityModel)
        {            
            var city = new Cities()
            {
                IdCity = cityId,
                Name = cityModel.Name,
                Country = cityModel.Country
            };

            _context.CityModel.Update(_mapper.Map<CityModel>(city));
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCityPatchAsync(int cityId, JsonPatchDocument cityModel)
        {
            var city = await _context.CityModel.FindAsync(cityId);
            if (city != null)
            {
                cityModel.ApplyTo(city);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCityAsync(int cityId)
        {
            var city = new Cities() { IdCity = cityId };

            _context.CityModel.Remove(_mapper.Map<CityModel>(city));

            await _context.SaveChangesAsync();
        }
    }
}
