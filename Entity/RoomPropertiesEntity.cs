using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public  class RoomPropertiesEntity
    {
        public int roomPropertyID  { get; set; }
        public string roomPropertyName { get; set; }    
        public bool isTheRoomPropertyActive { get; set; }
       
        public string roomPropertyDescription { get; set; }  


    }
}
