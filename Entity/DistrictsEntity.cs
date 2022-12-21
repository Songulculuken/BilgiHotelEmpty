using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DistrictsEntity
    {
        public int districtID { get; set; }
        public string districtName { get; set; }
        public bool isTheDistrictActive { get; set; }
        public string districtDescription { get; set; }
        public int cityID { get; set; }    
        public int countryID { get; set; } 
    }
}
