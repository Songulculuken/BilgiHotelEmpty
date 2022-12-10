using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ManagersEntity
    {
        public int managerID { get; set; }
        public string managerName { get; set; }
        public string managerSurname { get; set; }
        public string managerPhoneNumber { get; set; }
        public string managerEMail { get; set; }
        public string managerAddress { get; set; }
        public int countryID { get; set; }
        public int cityID { get; set; }
        public int districtID { get; set; }
        public int assignmentID { get; set; }
        public int genderID { get; set; }
        public string managerSalary { get; set; }
        public DateTime startingDateOfEmployment { get; set; }
        public DateTime endingDateOfEmployment { get; set; }
        public bool isTheManagerActive { get; set; }
        public string managerDescription { get; set; }
    }
}
 