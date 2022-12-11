using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GuestsEntity
    {
        public int guestID { get; set; }  
        public string guestName { get; set; }   
        public string guestSurname { get; set; }
        public string guestTCIdentificationNumbero { get; set; }   
        public DateTime guestBirthDate { get; set; } 
        public string guestPhoneNumber { get; set; }    
        public string guestEMail { get; set; }   
        public string guestAddress { get; set; }
        public int countryID { get; set; } 
        public int cityID { get; set; }    
        public int districtID { get; set; } 
        public int languageD { get; set; }  
        public int genderID { get; set; } 
        public bool isTheGuestActive { get; set; }
        public string guestDescription { get; set; }
    }
}
 