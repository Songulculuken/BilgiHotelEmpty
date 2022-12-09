using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CinsiyetlerEntity
    {
        public int cinsiyetID { get; set; } 
        public string cinsiyetAd { get; set; }  
        public bool cinsiyetAktifMi{ get; set; }
        public string cinsiyetAciklama { get; set; }
    }
}
