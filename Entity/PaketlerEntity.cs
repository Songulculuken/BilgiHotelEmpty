using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PaketlerEntity
    {
        public int paketID { get; set; }    
        public string paketOzellik { get; set; }    
        public decimal paketFiyat { get; set; }

        public bool paketAktifMi { get; set; }
        public string paketAciklama { get; set; }
    }
}
