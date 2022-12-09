using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RezervasyonlarEntity
    {
        public int rezervasyonID { get; set; }
        public DateTime rezervasyonIslemTarih { get; set; } 
        public DateTime rezervasyonBitisTarihi { get; set; }    
        public string rezervasyonIndirim { get; set; }  
        public bool rezervasyonAktifMi { get; set; } 
        public string rezervasyonAciklama { get; set; }
        public int calisanID { get; set; }
        public int rezervasyonTipID { get; set; }   
    }
}
