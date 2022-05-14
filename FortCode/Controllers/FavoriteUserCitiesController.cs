using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using FortRobotics.API.Data;
using FortRobotics.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FortRobotics.API.Repository;

namespace FortRobotics.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FavoriteUserCitiesController : ControllerBase
    {
        private readonly IUserCityRepository userCityRepository;

        public FavoriteUserCitiesController(IUserCityRepository userCityRepository)
        {
            this.userCityRepository = userCityRepository;
        }

        [HttpGet("")]

        public async Task<IActionResult> GetAllUserCities()
        {
            var userFavoriteCities = await userCityRepository.GetAllUserFavoriteCitiesAsync(HttpContext.User);
            if(userFavoriteCities == null)
            {
                return NotFound();
            }
            return Ok(userFavoriteCities);
        }


        [HttpPost("{id}")]
        public async Task<IActionResult> AddUserFavoriteCity([FromRoute] int id)
        {
            var idFavoriteUserCity = await userCityRepository.AddUserFavoriteCityAsync(id, HttpContext.User);
            return CreatedAtAction(nameof(AddUserFavoriteCity), new { id = id, controller = "FavoriteUserCities" }, idFavoriteUserCity);
        }

    }
}
