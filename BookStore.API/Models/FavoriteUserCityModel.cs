using FortRobotics.API.Models;

namespace FortRobotics.API.Models
{
    public class FavoriteUserCityModel
    {
        public string Id { get; set; }
        public UserModel UserModel { get; set; }

        public int IdCity { get; set; }

        public CityModel CityModel{ get; set; }
    }
}
