using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Lagerposition_has_Rezept
    {
        private int lagerposition_Lagerpositionsnummer;
        private int rezept_Rezeptnummer;
        private int menge;
        private String einheit;


        public int Lagerposition_has_Lagerpositionsnummer { get; set; }
        public int Rezept_Rezeptnummer { get; set; }
        public int Menge { get; set; }
        public string Einheit { get; set; }
    }
}
