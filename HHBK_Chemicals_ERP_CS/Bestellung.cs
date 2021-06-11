using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Bestellung
    {
        private int bestellpositionsnummer;
        private int bestellungsnummer;
        private int menge;
        private DateTime bestelldatum;
        private Produkt produkt=new Produkt();
        private Kunde kunde=new Kunde();
        private Lieferung lieferung=new Lieferung();

        public int Bestellpositionsnummer { get => bestellpositionsnummer; set => bestellpositionsnummer = value; }
        public int Bestellungsnummer { get => bestellungsnummer; set => bestellungsnummer = value; }
        public int Menge { get => menge; set => menge = value; }
        public DateTime Bestelldatum { get => bestelldatum; set => bestelldatum = value; }
        internal Produkt Produkt { get => produkt; set => produkt = value; }
        internal Kunde Kunde { get => kunde; set => kunde = value; }
        internal Lieferung Lieferung { get => lieferung; set => lieferung = value; }
    }
}
