using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CitiesEntity
    {
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int countryID { get; set; }
        public bool isTheCityActive { get; set; }
        public string cityDescription { get; set; }
    }
}
