using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ReservationTypeEntity
    {
        public int reservationTypeID { get; set; }
        public string reservationTypeName { get; set; }    
        public bool isTheReservationTypeActive { get; set; } 
        public string reservationTypeDescription{ get; set; }  
    }
}
