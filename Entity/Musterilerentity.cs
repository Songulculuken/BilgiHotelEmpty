using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Musterilerentity
    {
        public int musteriID { get; set; }  
        public string musteriAd { get;
        set;}
        public string musteriSoyad { get; set;}
        public string musteriTelNo { get; set;} 
        public string musteriEposta { get; set;}    
        public string musteriAdres { get; set; }
        public string musteriFirmaAd { get; set;}   
        public string firmaVergiNo { get; set;}

        public bool musteriSirketMi { get; set;}
        public int ulkeID { get; set; } 
        public int sehirID { get; set; }    
        public int ilceID { get; set; } 
        public int dilID { get; set; }  
        public int cinsiyetID { get; set; } 
        public int kampanyaID { get; set; }
        public bool musteriAktifMi { get; set; }    
        public string musteriAciklama { get; set; } 
    }
}
