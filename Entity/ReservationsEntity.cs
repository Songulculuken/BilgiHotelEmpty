using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ReservationsEntity
    {
        public int reservationID { get; set; }
        public DateTime reservationTransactionDate{ get; set; } 
        public DateTime reservationEndDate { get; set; }    
        public string reservationDiscount { get; set; }  
        public bool isTheReservationActive { get; set; } 
        public string reservationDescription { get; set; }
        public int employeeID { get; set; }
        public int reservationTypeID { get; set; }   
    }
}
