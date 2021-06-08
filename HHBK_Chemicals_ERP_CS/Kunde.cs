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
        private string passwort;

        public Kunde(int kundennummer, string name, string vorname, string strasse, string hausnummer, string ort, int postleitzahl, string emailadresse)
        {
            this.kundennummer = kundennummer;
            this.Name = name;
            this.Vorname = vorname;
            this.Strasse = strasse;
            this.Hausnummer = hausnummer;
            this.Ort = ort;
            this.postleitzahl = postleitzahl;
            this.emailadresse = emailadresse;
            
        }

        public Kunde()

        {


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

            set { this.kundennummer = value; }


        }

        public string Emailadresse {
            get => emailadresse;
            set => emailadresse = value;
        }
        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public string Hausnummer { get => hausnummer; set => hausnummer = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Passwort { get => passwort; set => passwort = value; }
    }
}
