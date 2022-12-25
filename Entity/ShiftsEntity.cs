using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ShiftsEntity
    {
        public int shiftID { get; set; }  
        public string shiftName { get; set; }   
        public DateTime shiftStartTime { get; set; } 
        public DateTime shiftFinishTime { get; set; }
        public bool isTheShiftActive { get; set; }    
        public string shiftDescription { get; set; }
    }
}
