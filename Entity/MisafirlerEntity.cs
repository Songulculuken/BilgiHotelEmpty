using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MisafirlerEntity
    {
        public int misafirID { get; set; }  
        public string misafirAd { get; set; }   
        public string misafirSoyad { get; set; }
        public string misafirTCKimlikNo { get; set; }   
        public DateTime misafirDogumTarih { get; set; } 
        public string misafirTelefonNo { get; set; }    
        public string misafirEposta { get; set; }   
        public string misafirAdres { get; set; }
        public int ulkeID { get; set; } 
        public int sehirID { get; set; }    
        public int ilceID { get; set; } 
        public int dilID { get; set; }  
        public int cinsiyetID { get; set; } 
        public bool misafirAktifMi { get; set; }
        public string misafirAciklama {get; set; }
    }
}
