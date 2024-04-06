using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CitiesService
    {
        private List<string> _cities;
        public CitiesService()
        {
            _cities = new List<string>()
            {
            "London",
            "Paris",
            "New York",
            "Tokyo",
            "Rome"
            };
        }
        public List<string> GetCities()
        {
            return _cities;
        }
    } 
}
