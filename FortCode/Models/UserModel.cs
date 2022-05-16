using FortCode.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FortCode.Models
{

    public class UserModel : IdentityUser
    {
        public string Name { get; set; }

        public IList<FavoriteUserCityModel> favoriteUserCities { get; set; }
    }
}
