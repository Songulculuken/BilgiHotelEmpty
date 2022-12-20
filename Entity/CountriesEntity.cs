using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CountriesEntity
    {
        public int countryID { get; set; }
        public string countryName { get; set; }  
        public bool isTheCountryActive { get; set;}
        public string countryDescription { get; set; }    
    }
}
