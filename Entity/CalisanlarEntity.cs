using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CalisanlarEntity
    {
        public int calisanID { get; set; }   
        public string calisanAd{ get; set; }
        public string calisanSoyad { get; set; }
        public string calisanTCKimlikNo { get; set; }
        public DateTime calisanDogumTarih { get; set; }    
        public string calisanTelefonNo { get; set; }    
        public string calisanEposta { get; set; }  
        public string calisanAdres { get; set; }
        public int ulkeID { get; set; } 
        public int sehirID { get; set;}
        public int ilceID { get; set; } 
        public int gorevID { get; set;}
        public int cinsiyetID { get; set; }
        public string calisanSaatlikUcret { get; set;}
        public string calisanMaas { get; set; }
        public string calisanSicilNo { get; set; }  
        public bool calisanEngelliMi { get; set; }  
        public string calisanAcilDurumKisiAd { get; set; }  
        public string calisanAcilDurumTelefonNo { get; set; }

        public  DateTime calisanIseBaslamaTarih { get; set; }   
        public DateTime calisanIstenCikisTarih { get; set; }    
        public string calisanCalismaDurumu { get; set; }    
        public bool calisanAktifMi { get; set; }    
        public string calisanAciklama { get; set; } 

    }
}
