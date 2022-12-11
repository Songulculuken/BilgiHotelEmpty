using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RoomTypesEntity
    {
        public int roomTypeID { get; set; }
        public string roomTypeProperty { get; set; }
        public bool isTheRoomTypeActive { get; set; }

        public string roomTypeDescription { get; set; }
    }
}
