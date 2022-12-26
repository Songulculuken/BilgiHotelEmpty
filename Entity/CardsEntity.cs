using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CardsEntity
    {
        public int cardID { get; set; } 
        public int cardNumber { get; set; }
        public DateTime cardReceiveDate { get; set; }
        public DateTime cardDeliveryDate { get; set; }
        public bool isTheCardActive { get; set; }
        public string cardDescription{ get; set; }
        public int roomID { get; set; }
        public int employeeID { get; set; }  
        public int guestID { get; set; }  
    }
}
