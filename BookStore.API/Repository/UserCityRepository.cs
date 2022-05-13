using AutoMapper;
using FortRobotics.API.Data;
using FortRobotics.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using FortRobotics.API.Helpers;
using Microsoft.AspNetCore.Http;

namespace FortRobotics.API.Repository
{
    public class UserCityRepository : IUserCityRepository
    {
        private readonly FRContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<UserModel> userManager;
        private readonly ICityRepository cityRepository;

        public UserCityRepository(FRContext context, IMapper mapper, UserManager<UserModel> userManager, ICityRepository cityRepository)
        {
            _context = context;
            _mapper = mapper;
            this.userManager = userManager;
            this.cityRepository = cityRepository;
        }

        public async Task<FavCities> GetAllUserFavoriteCitiesAsync(ClaimsPrincipal claimsPrincipal)
        {
            List<FavoriteUserCityModel> favoriteUserCities = await _context.FavoriteUserCities
                .Include(x => x.UserModel)
                .Include(x => x.CityModel)
                .Where(x => x.UserModel.Email == claimsPrincipal.Identity.Name)
                .ToListAsync();

            FavCities favCities = null; 

            if (favoriteUserCities != null && favoriteUserCities.FirstOrDefault() != null)
            {
                UserModel userModel = favoriteUserCities.FirstOrDefault().UserModel;
                favCities = new FavCities()
                {
                    Name = userModel.Name,
                    Email = userModel.Email,
                    favCities = _mapper.Map<List<Cities>>(favoriteUserCities.Select(x => x.CityModel).ToList())
                };
            }
          
            return favCities;
        }

        public async Task<int> AddUserFavoriteCityAsync(int id, ClaimsPrincipal claimsPrincipal)
        {
            var city = await cityRepository.GetCityByIdAsync(id);
            var cityModel = _mapper.Map<CityModel>(city);

            var user = await userManager.FindByEmailAsync(claimsPrincipal.Identity.Name);
            var userModel = _mapper.Map<UserModel>(user);

            FavoriteUserCityModel favoriteUserCityModel = new FavoriteUserCityModel()
            {
                Id = userModel.Id,
                UserModel = userModel,
                IdCity = id,
                CityModel = cityModel
            };

            _context.FavoriteUserCities.Add(favoriteUserCityModel);
            await _context.SaveChangesAsync();
            int.TryParse(favoriteUserCityModel.Id, out int result);
            return result;
        }

        public async Task DeleteUserFavoriteCityAsync(int userCityId)
        {
            _context.FavoriteUserCities.Remove(_context.FavoriteUserCities.FirstOrDefault(c => c.IdCity == userCityId));
            await _context.SaveChangesAsync();
        }
    }
}
