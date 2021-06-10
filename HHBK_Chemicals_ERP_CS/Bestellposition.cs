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
        private int produkt_artikelnummer;
        private int kunde_kundennummer;
        private int lieferpositioon_idLieferposition;

        public int Bestellpositionsnummer { get => bestellpositionsnummer; set => bestellpositionsnummer = value; }
        public int Bestellungsnummer { get => bestellungsnummer; set => bestellungsnummer = value; }
        public int Menge { get => menge; set => menge = value; }
        public DateTime Bestelldatum { get => bestelldatum; set => bestelldatum = value; }
        public int Produkt_artikelnummer { get => produkt_artikelnummer; set => produkt_artikelnummer = value; }
        public int Kunde_kundennummer { get => kunde_kundennummer; set => kunde_kundennummer = value; }
        public int Lieferpositioon_idLieferposition { get => lieferpositioon_idLieferposition; set => lieferpositioon_idLieferposition = value; }
    }
}
