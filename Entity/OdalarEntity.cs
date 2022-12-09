using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OdalarEntity
    {
        public int odaNo { get; set; }
        public int odaTipID { get; set; }
        public int kat { get; set; }
        public decimal odaFiyat { get; set; }

        public bool odaAktifMi { get; set; }    

        public string odaAciklama { get; set; } 
    }
}
