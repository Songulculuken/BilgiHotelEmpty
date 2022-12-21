using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AssignmentsEntity
    {
        public int assignmentID { get; set; }    
        public string assignmentName { get; set; } 
        public bool isTheAssignmentActive { get; set; }
        public string assignmentDescription { get; set; }   
    }
}
