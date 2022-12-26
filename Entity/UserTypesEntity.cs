using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserTypesEntity
    {
        public int userTypeID { get; set; } 
        public string userTypeName { get; set; } 
        public bool isTheUserTypeActive { get; set; }
        public string userTypeDescription { get; set; }   
    }
}
