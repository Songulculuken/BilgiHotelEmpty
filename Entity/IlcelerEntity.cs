using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class IlcelerEntity
    {
        public int ilceID { get; set; }
        public string ilceAd { get; set; }
        public bool ilceAktifMi { get; set; }
        public string ilceAciklama { get; set; }
        public int sehirID { get; set; }    
        public int ulkeID { get; set; } 
    }
}
