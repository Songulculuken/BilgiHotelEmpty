using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PackagesEntity
    {
        public int packageID { get; set; }    
        public string packageProperty { get; set; }    
        public decimal packagePrice { get; set; }

        public bool isThePackageActive { get; set; }
        public string packageDescription { get; set; }
    }
}
