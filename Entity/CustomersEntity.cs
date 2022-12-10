using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class CustomersEntity
    {
        public int customerID { get; set; }  
        public string customerName{ get;
        set;}
        public string customerSurname { get; set;}
        public string customerPhoneNumber { get; set;} 
        public string customerEMail { get; set;}    
        public string customerAddress { get; set; }
        public string customerCompanyName { get; set;}   
        public string companyTaxNumber { get; set;}

        public bool isTheCustomerCompany { get; set;}
        public int countryID { get; set; } 
        public int cityID { get; set; }    
        public int districtID { get; set; } 
        public int languageID { get; set; }  
        public int genderID { get; set; } 
        public int campaignID { get; set; }
        public bool isTheCustomerActive { get; set; }    
        public string customerDescription { get; set; } 
    }
}

