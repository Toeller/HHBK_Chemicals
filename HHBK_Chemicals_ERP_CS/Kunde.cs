using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Kunde
    {
        private int kundennummer;
        private string name;
        private string vorname;
        private string strasse;
        private string hausnummer;
        private string ort;
        private int postleitzahl;
        private string emailadresse;

        public int Kundennummer
        {
            get {
                return kundennummer;
            }
            
        }

        public int Postleitzahl { 
            get => postleitzahl;
            set
            { 
                if(value >= 1000 && value <= 99999)
                    postleitzahl = value;
            }
        }
    }
}
