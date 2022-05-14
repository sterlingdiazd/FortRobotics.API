using FortCode.Data;
using FortCode.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FortCode.Repository
{
    public interface IUserCityRepository
    {
        Task<List<CityModel>> GetAllCityModelsAsync();
        Task<CityModel> GetCityModelByIdAsync(int cityId);

        Task<FavCities> GetAllUserFavoriteCitiesAsync(ClaimsPrincipal claimsPrincipal);
        Task<int> AddUserFavoriteCityAsync(int id, ClaimsPrincipal claimsPrincipal);
        Task DeleteUserFavoriteCityAsync(int userCityId);
    }
}
