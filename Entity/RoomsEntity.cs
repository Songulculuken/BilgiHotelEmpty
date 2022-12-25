using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RoomsEntity
    {
        public int roomNumber { get; set; }
        public int roomTypeID { get; set; }
        public int floor { get; set; }
        public decimal roomPrice { get; set; }

        public bool isTheRoomActive{ get; set; }    

        public string roomDesciption { get; set; } 
    }
}
