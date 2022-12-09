using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class YetkilerEntity
    {
        public int yetkiID { get; set; }
        public string yetkiAd { get; set; } 
        public string yetkiErisimKodu { get; set; }
        public bool yetkiAktifMi { get; set; }
        public string yetkiAciklama { get; set; }
    }
}
