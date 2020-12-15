using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Produktionsposition
    {
        private int produktionsnummer;
        private int produkt_Artikelnummer;
        private DateTime datumProduktionsfreigabe;
        private DateTime datumProduktion;
        private string nameProduktionsfreigabe;
        private string nameProduzent;
        private int bestellposition_Bestellpoitionsnummer;
        private int bestellposition_Kunde_Kundennummer;

        public int Produktionsnummer { get => produktionsnummer; set => produktionsnummer = value; }
        public int Produkt_Artikelnummer { get => produkt_Artikelnummer; set => produkt_Artikelnummer = value; }
        public DateTime DatumProduktionsfreigabe { get => datumProduktionsfreigabe; set => datumProduktionsfreigabe = value; }
        public DateTime DatumProduktion { get => datumProduktion; set => datumProduktion = value; }
        public string NameProduktionsfreigabe { get => nameProduktionsfreigabe; set => nameProduktionsfreigabe = value; }
        public string NameProduzent { get => nameProduzent; set => nameProduzent = value; }
        public int Bestellposition_Bestellpoitionsnummer { get => bestellposition_Bestellpoitionsnummer; set => bestellposition_Bestellpoitionsnummer = value; }
        public int Bestellposition_Kunde_Kundennummer { get => bestellposition_Kunde_Kundennummer; set => bestellposition_Kunde_Kundennummer = value; }
    }
}
