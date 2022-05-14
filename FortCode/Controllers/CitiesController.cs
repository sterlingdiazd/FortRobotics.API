using FortCode.Models;
using FortCode.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CitiesController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet("")]
        
        public async Task<IActionResult> GetAllCities()
        {
            var cities = await _cityRepository.GetAllCitiesAsync();
            return Ok(cities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCityById([FromRoute] int id)
        {
            var city = await _cityRepository.GetCityByIdAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewCity([FromBody] CityModel cityModel)
        {
            var id = await _cityRepository.AddCityAsync(cityModel);
            return CreatedAtAction(nameof(GetCityById), new { id = id, controller = "cities" }, id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCity([FromBody] CityModel cityModel, [FromRoute] int id)
        {
            await _cityRepository.UpdateCityAsync(id, cityModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity([FromRoute] int id)
        {
            await _cityRepository.DeleteCityAsync(id);
            return Ok();
        }
    }
}
