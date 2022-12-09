using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KartlarEntity
    {
        public int kartID { get; set; } 
        public int kartNumara { get; set; }
        public DateTime kartAlmaTarihi { get; set; }
        public DateTime KartTeslimTarihi { get; set; }
        public bool kartAktifMi { get; set; }
        public string kartAciklama { get; set; }
        public int odaID { get; set; }
        public int calisanID { get; set; }  
        public int misafirID { get; set; }  
    }
}
