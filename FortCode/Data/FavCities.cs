using System.Collections.Generic;

namespace FortRobotics.API.Data
{
    public class FavCities
    {
        public string Name { get; set; }
        public string Email { get; set; }        
        public List<Cities> favCities { get; set; }
    }
}
