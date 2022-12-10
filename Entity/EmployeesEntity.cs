using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmployeesEntity
    {
        public int employeeID { get; set; }   
        public string employeeName { get; set; }
        public string employeeSurname { get; set; }
        public string employeeTCIdentificationNumber { get; set; }
        public DateTime employeeBirthDate { get; set; }    
        public string employeePhoneNumber { get; set; }    
        public string employeeEMail { get; set; }  
        public string employeeAddress { get; set; }
        public int countryID { get; set; } 
        public int cityID { get; set;}
        public int districtID { get; set; } 
        public int assignmentID { get; set;}
        public int genderID { get; set; }
        public string employeeHourlyWage { get; set;}
        public string employeeSalary { get; set; }
        public string employeeRegistrationNumber { get; set; }  
        public bool isTheEmployeeDisabled { get; set; }  
        public string employeeEmergencyName { get; set; }  
        public string employeeEmergencyPhoneNo { get; set; }

        public  DateTime employeeStartingDateOfEmployment { get; set; }   
        public DateTime employeeEndingDateOfEmployment { get; set; }    
        public string employeeWorkingStatus { get; set; }    
        public bool isTheEmployeeActive { get; set; }    
        public string employeeDescription { get; set; } 

    }
}


