using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PaymentsEntity
    {
        public int paymentID { get; set; }    
        public string paymentType { get; set; }   
        public decimal paymentDiscount { get; set; }
        public bool isThePaymentActive { get; set; }
        public string paymentDescription { get; set; }

    }
}
