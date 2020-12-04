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


        public int Lagerposition_Lagerpositionsnummer { get => lagerposition_Lagerpositionsnummer; set => lagerposition_Lagerpositionsnummer = value; }
        public int Rezept_Rezeptnummer1 { get => rezept_Rezeptnummer; set => rezept_Rezeptnummer = value; }
        public int Menge1 { get => menge; set => menge = value; }
        public string Einheit1 { get => einheit; set => einheit = value; }
    }
}
