using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EkstralarEntity
    {
        public int ekstraID { get; set; }   
        public string ekstraAd { get; set; }
        public decimal ekstraFiyat { get; set; }    
        public bool ekstraAktifMi { get; set; }
        public string ekstraAciklama { get; set; }
    }
}
