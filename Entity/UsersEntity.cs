using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UsersEntity
    {
        public int userID { get; set; }    
        public string userName { get; set; }    
        public string userPassword { get; set; } 
        public string userEMail { get; set; }  
        public bool userEMailAssent { get; set; } 
        public bool isTheUserActive { get; set; }  
        public string userDescription { get; set; }   
        public int userTypeID { get; set; }    
    }
}
