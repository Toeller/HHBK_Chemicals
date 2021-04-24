using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Zahlungseingang
    {
        private int zahlungseingangsnummer;
        private string verwendungszweckKdNr;
        private string verwendungszweckBestNr;
        private DateTime datum;
        private string nameKontoinhaber;
        private string iBAN;
        private int kundennummer;


        public Zahlungseingang(int zahlungseingangsnummer, string verwendungszweckKdNr, string verwendungszweckBestNr, DateTime datum, string nameKontoinhaber, string iBAN, int kundennummer) 
        {
            this.zahlungseingangsnummer = zahlungseingangsnummer;
            this.verwendungszweckKdNr = verwendungszweckKdNr;
            this.verwendungszweckBestNr = verwendungszweckBestNr;
            this.datum = datum;
            this.nameKontoinhaber = nameKontoinhaber;
            this.iBAN = iBAN;
            this.kundennummer = kundennummer;
        } 



        public int Zahlungseingangsnummer 
        { 
            get => zahlungseingangsnummer; 
            set => zahlungseingangsnummer = value;
        }
        public string VerwendungszweckKdNr 
        {
            get => verwendungszweckKdNr;
            set => verwendungszweckKdNr = value; 
        }
        public string VerwendungszweckBestNr 
        { 
            get => verwendungszweckBestNr; 
            set => verwendungszweckBestNr = value; 
        }
        public DateTime Datum 
        { 
            get => datum; 
            set => datum = value; 
        }
        public string NameKontoinhaber 
        { 
            get => nameKontoinhaber; 
            set => nameKontoinhaber = value; 
        }
        public string IBAN 
        {
            get => iBAN; 
            set => iBAN = value; 
        }
        public int Kundennummer 
        {
            get => kundennummer; 
            set => kundennummer = value; 
        }
    }
}
