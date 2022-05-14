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
    public class TestController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public TestController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet("")]
        
        public async Task<IActionResult> GetAllCities()
        {
            var cities = await _cityRepository.GetAllCitiesAsync();
            return Ok(cities);
        }

    }
}
