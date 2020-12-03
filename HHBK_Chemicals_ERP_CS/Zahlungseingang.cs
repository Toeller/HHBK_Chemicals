using System;

namespace HHBK_Chemicals_ERP_CS
{
    public class Zahlungseingang
    {
        private int zahlungseingangsnummer;
        private string verwendungszweckKdNr;
        private string verwendungszweckBestNr;
        private DateTime datum;
        private string nameKontoinhaber;
        private string iBAN;
        private int kundennummer;

        public int Zahlungseingangsnummer 
        { 
            get => zahlungseingangsnummer; 
            set => zahlungseingangsnummer = value; 
        }
        public string IBAN { 
            get => iBAN; 
            set => iBAN = value;
        }
    }
}