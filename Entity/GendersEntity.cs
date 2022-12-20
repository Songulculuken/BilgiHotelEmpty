using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GendersEntity
    {
        public int genderID { get; set; } 
        public string genderName { get; set; }  
        public bool isTheGenderActive { get; set; }
        public string genderDescription { get; set; }
    }
}
