using FortRobotics.API.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FortRobotics.API.Models
{
    public class UserModel : IdentityUser
    {
        //[Key]
        //public int Id { get; set; }
        public string Name { get; set; }

        public IList<FavoriteUserCityModel> favoriteUserCities { get; set; }
    }
}
