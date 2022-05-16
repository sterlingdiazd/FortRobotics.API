using System.ComponentModel.DataAnnotations.Schema;
using FortCode.Models;

namespace FortCode.Models
{
    [Table("FavoriteUserCityModel")]
    public class FavoriteUserCityModel
    {
        public string Id { get; set; }
        public UserModel UserModel { get; set; }

        public int IdCity { get; set; }

        public CityModel CityModel{ get; set; }
    }
}
