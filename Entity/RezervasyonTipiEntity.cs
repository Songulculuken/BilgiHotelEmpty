using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RezervasyonTipiEntity
    {
        public int rezervasyonTipID { get; set; }
        public string rezervasyonTipAd { get; set; }    
        public bool rezervasyonTipAktifMi { get; set; } 
        public string rezervasyonTipAciklama { get; set; }  
    }
}
