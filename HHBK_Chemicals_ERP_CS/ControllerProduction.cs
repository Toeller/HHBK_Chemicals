using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerProduction : IControllerProduction
    {
        private int produktionspositionsnummer;
        private int produkt_Artikelnummer;
        private DateTime datumProduktionsfreigabe;
        private DateTime datumProduktion;
        private char nameProdkutionsfreigabe;
        private char nameProduzent;
        private int bestellposition_Bestellpositionsnummer;
        private int bestellposition_Kunde_Kundennummer;

        public int Produktionspositionsnummer { get; set; }
        public int Produkt_Artikelnummer { get; set; }
        public DateTime DatumProduktionsfreigabe { get; set; }
        public DateTime DatumProduktion { get; set; }
        public char NameProdkutionsfreigabe { get; set; }
        public char NameProduzent { get; set; }
        public int Bestellposition_Bestellpositionsnummer { get; set; }
        public int Bestellposition_Kunde_Kundennummer { get; set; }


    }
}
