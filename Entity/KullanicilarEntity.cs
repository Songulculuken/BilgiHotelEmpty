using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KullanicilarEntity
    {
        public int kullaniciID { get; set; }    
        public string kullaniciAd{ get; set; }    
        public string kullaniciSifre { get; set; } 
        public string kullaniciEposta { get; set; }  
        public bool kullaniciEpostaOnay{ get; set; } 
        public DateTime kullaniciUyelikTarih { get; set; }
        public DateTime kullaniciSonGirisTarih { get; set; }    
        public int resimID { get; set; }
        public bool kullaniciAktifMi { get; set; }  
        public string kullaniciAciklama { get; set; }   
        public int kullaniciTipiID { get; set; }    
    }
}
