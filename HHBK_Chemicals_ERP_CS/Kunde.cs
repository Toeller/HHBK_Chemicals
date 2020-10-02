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
        
        public int Postleitzahl
        {
            get
            {
                return postleitzahl;
            }
            set
            {
                if(value>=01000 && value<=99999)
                {
                    postleitzahl = value;
                }
            }
        }

        public int Kundennummer
        {
            get
            {
                return this.kundennummer;
            }
            


        }

        public string Emailadresse {
            get => emailadresse;
            set => emailadresse = value;
        }
    }
}
