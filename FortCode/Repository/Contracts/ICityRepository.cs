using FortCode.Data;
using FortCode.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FortCode.Repository
{
    public interface ICityRepository
    {
        Task<List<Cities>> GetAllCitiesAsync();
        Task<Cities> GetCityByIdAsync(int cityId);

        Task<int> AddCityAsync(CityModel cityModel);
        Task UpdateCityAsync(int cityId, CityModel cityModel);
        Task UpdateCityPatchAsync(int cityId, JsonPatchDocument cityModel);
        Task DeleteCityAsync(int cityId);
    }
}
