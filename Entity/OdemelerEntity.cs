using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OdemelerEntity
    {
        public int odemeID { get; set; }    
        public string odemeTipi { get; set; }   
        public decimal odemeIndirimi { get; set; }
        public bool odemeAktifMi { get; set; }
        public string odemeAciklama { get; set; }

    }
}
