using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SatislarEntity
    {
        public int satisID { get; set; }    
        public decimal satisIndirim { get; set; }   
        public int odaID { get; set; }
        public int kartID { get; set; }
        public int paketID { get; set; }
        public bool satisAktifMi { get; set; }  
        public string satisAciklama { get; set; }   
        public DateTime odaSatisGirisTarihi { get; set; }
        public DateTime odaSatisCikisTarihi { get; set; }
        public decimal odaSatisFiyat { get; set; }  
        public decimal odaSatisKDV { get; set; }    
    }
}
