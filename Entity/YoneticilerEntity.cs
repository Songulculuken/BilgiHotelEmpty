using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class YoneticilerEntity
    {
        public int yoneticiID { get; set; }
        public string yoneticiAd { get; set; }
        public string yoneticiSoyad { get; set; }
        public string yoneticiTelNo { get; set; }
        public string yoneticiEPosta { get; set; }
        public string yoneticiAdres { get; set; }
        public int ulkeID { get; set; }
        public int sehirID { get; set; }
        public int ilceID { get; set; }
        public int gorevID { get; set; }
        public int cinsiyetID { get; set; }
        public string yoneticiMaas { get; set; }
        public DateTime yoneticiIseBaslamaTarihi { get; set; }
        public DateTime yoneticiIstenCikisTariih { get; set; }
        public bool yoneticiAktifMi { get; set; }
        public string yoneticiAciklama { get; set; }
    }
}
