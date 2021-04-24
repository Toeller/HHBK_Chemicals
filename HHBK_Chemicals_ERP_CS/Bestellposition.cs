using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Bestellposition
    {
        private int bestellpositionsnummer;
        private int bestellungsnummer;
        private int menge;
        private DateTime bestelldatum;
        private int produkt_Artikelnummer1;
        private int kunde_Kundennummer;
        private int lieferposition_idLieferposition;

        public int Bestellpositionsnummer { get => bestellpositionsnummer; set => bestellpositionsnummer = value; }
        public int Bestellungsnummer { get => bestellungsnummer; set => bestellungsnummer = value; }
        public int Menge { get => menge; set => menge = value; }
        public DateTime Bestelldatum { get => bestelldatum; set => bestelldatum = value; }
        public int Produkt_Artikelnummer1 { get => produkt_Artikelnummer1; set => produkt_Artikelnummer1 = value; }
        public int Kunde_Kundennummer { get => kunde_Kundennummer; set => kunde_Kundennummer = value; }
        public int Lieferposition_idLieferposition { get => lieferposition_idLieferposition; set => lieferposition_idLieferposition = value; }
    }
}
