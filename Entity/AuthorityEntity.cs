using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AuthorityEntity
    {
        public int authorityID { get; set; }
        public string authorityName { get; set; } 
        public string authorityAccessCode { get; set; }
        public bool isTheAuthorityActive{ get; set; }
        public string authorityDescription { get; set; }
    }
}
