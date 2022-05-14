using System.Collections.Generic;

namespace FortCode.Data
{
    public class FavCities
    {
        public string Name { get; set; }
        public string Email { get; set; }        
        public List<Cities> favCities { get; set; }
    }
}
