using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SehirlerEntity
    {
        public int sehirID { get; set; }
        public string sehirAd { get; set; }
        public int ulkeID { get; set; }
        public bool sehirAktifMi { get; set; }
        public string sehirAciklama { get; set; }
    }
}
