using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LanguagesEntity
    {
        public int languageID { get; set; }  
        public string languageName { get; set; }
        public bool isTheLanguageActive { get; set; }
        public int languageCode { get; set; } 
        public string languageDescription { get; set; }

    }
}
