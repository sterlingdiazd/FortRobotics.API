using FortCode.Models;

namespace FortCode.Models
{
    public class FavoriteUserCityModel
    {
        public string Id { get; set; }
        public UserModel UserModel { get; set; }

        public int IdCity { get; set; }

        public CityModel CityModel{ get; set; }
    }
}
