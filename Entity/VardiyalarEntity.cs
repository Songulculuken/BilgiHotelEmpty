using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VardiyalarEntity
    {
        public int vardiyaID { get; set; }  
        public string vardiyaAd { get; set; }   
        public DateTime vardiyaBaslangicSaati { get; set; } 
        public DateTime vardiyaBitisSaati { get; set; }
        public bool vardiyaAktifMi { get; set; }    
        public string vardiyaAciklama { get; set; }
    }
}
