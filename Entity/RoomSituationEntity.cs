using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RoomSituationEntity
    {
       public int roomSituationID { get; set; }  
        public string roomSituationName { get; set; }
        public bool isTheRoomSituationActive { get; set; }   
        public string roomSituationDescription { get; set; }    
    }
}
