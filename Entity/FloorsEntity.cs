using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FloorsEntity
    {
        public int floorID { get; set; }  
        public int floorNumber { get; set; }    
        public string floorProperty { get; set; }  
        public bool doesTheFloorHaveABalcony { get; set; }    
        public bool isTheFloorActive { get; set; }
        public string floorDescription { get; set; }
    }
}
