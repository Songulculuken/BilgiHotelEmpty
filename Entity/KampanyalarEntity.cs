using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KampanyalarEntity
    {
        public int kampanyaID { get; set; }
        public string kampanyaAd{ get; set; }

        public string kampanyaIndirim{ get; set; }

        public DateTime kampanyaBaslangicTarihi{ get;set; }
        public DateTime kampanyaBitisTarihi { get; set; }
        public bool kampanyaAktifMi { get; set; }  public string kampanyaAciklama { get; set; } 

    }
}
