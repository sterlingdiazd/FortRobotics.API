using FortRobotics.API.Data;
using FortRobotics.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FortRobotics.API.Repository
{
    public interface IUserCityRepository
    {
        Task<FavCities> GetAllUserFavoriteCitiesAsync(ClaimsPrincipal claimsPrincipal);
        Task<int> AddUserFavoriteCityAsync(int id, ClaimsPrincipal claimsPrincipal);
        Task DeleteUserFavoriteCityAsync(int userCityId);
    }
}
