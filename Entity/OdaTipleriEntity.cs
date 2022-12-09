using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OdaTipleriEntity
    {
        public int odaTipiID { get; set; }
        public string odaTipiOzellik { get; set; }
        public bool odaTipiAktifMi { get; set; }

        public string odaTipiAciklama { get; set; }
    }
}
