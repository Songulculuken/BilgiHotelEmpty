using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ExtrasEntity
    {
        public int extraID { get; set; }   
        public string extraName { get; set; }
        public decimal extraPrice { get; set; }    
        public bool isTheExtraActive { get; set; }
        public string extraDescription { get; set; }
    }
}
