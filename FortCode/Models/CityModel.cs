using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FortCode.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FortCode.Models
{
    [Table("CityModel")]
    public class CityModel
    {
        [Key]
        public int IdCity { get; set; }

        [Required(ErrorMessage ="Please add city name")]
      
        public string Name { get; set; }
        [Required(ErrorMessage = "Please add the country of the city")]
        public string Country { get; set; }

        // [ForeignKey("FavoriteUserCities")]    
        public IList<FavoriteUserCityModel> favoriteUserCities { get; set; }

    }
}
