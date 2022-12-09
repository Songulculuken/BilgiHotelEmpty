using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KatlarEntity
    {
        public int katID { get; set; }  
        public int katNumarasi { get; set; }    
        public string katOzellikleri { get; set; }  
        public bool katBalkonVarmi { get; set; }    
        public bool katAktifMi { get; set; }
        public string katAciklama { get; set; }
    }
}
