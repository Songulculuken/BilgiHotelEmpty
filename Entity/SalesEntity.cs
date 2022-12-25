using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SalesEntity
    {
        public int salesID { get; set; }    
        public decimal salesDiscount { get; set; }   
        public int roomID { get; set; }
        public int cardID { get; set; }
        public int packageID { get; set; }
        public bool isTheSalesActive { get; set; }  
        public string salesDescription { get; set; }   
        public DateTime roomSalesEntryDate { get; set; }
        public DateTime roomSalesExitDate { get; set; }
        public decimal roomSalesPrice { get; set; }  
        public decimal roomSalesKDV { get; set; }    
    }
}
