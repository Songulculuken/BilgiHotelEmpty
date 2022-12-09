using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KullaniciTipleriEntity
    {
        public int kullanicTipiID { get; set; } 
        public string kullaniciTipiAd { get; set; } 
        public bool kullaniciTipiAktifMi { get; set; }
        public string kullaniciTipiAciklama { get; set; }   
    }
}
