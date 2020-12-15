using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Rechnungsposition
    {
        private int rechnungspositionsnummer;
        private int rechnungsnummer;
        private int bestellposition_Bestellpositionsnummer;
        private int bestellposition_Produkt_Artikelnummer1;
        private int bestellposition_Kunde_Kundennummer;

        public int Rechnungspositionsnummer { get => rechnungspositionsnummer; set => rechnungspositionsnummer = value; }
        public int Rechnungsnummer { get => rechnungsnummer; set => rechnungsnummer = value; }
        public int Bestellposition_Bestellpositionsnummer { get => bestellposition_Bestellpositionsnummer; set => bestellposition_Bestellpositionsnummer = value; }
        public int Bestellposition_Produkt_Artikelnummer1 { get => bestellposition_Produkt_Artikelnummer1; set => bestellposition_Produkt_Artikelnummer1 = value; }
        public int Bestellposition_Kunde_Kundennummer { get => bestellposition_Kunde_Kundennummer; set => bestellposition_Kunde_Kundennummer = value; }
    }
}
