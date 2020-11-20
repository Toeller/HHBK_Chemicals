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
        //hallo
        public Kunde(int kundennummer, string name, string vorname, string strasse, string hausnummer, string ort, int postleitzahl, string emailadresse)
        {
            this.kundennummer = kundennummer;
            this.name = name;
            this.vorname = vorname;
            this.strasse = strasse;
            this.hausnummer = hausnummer;
            this.ort = ort;
            this.postleitzahl = postleitzahl;
            this.emailadresse = emailadresse;
            
        }

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
