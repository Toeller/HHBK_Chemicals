using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Lieferung
    {
        private int idLieferposition;
        private string liefernummer;
        private DateTime versanddatum;
        private DateTime lieferdatum;
        private string nameVersandkontrolle;
        private string nameSpedition;
        //private Bestellung bestellung = new Bestellung();

        public int IdLieferposition { get => idLieferposition; set => idLieferposition = value; }
        public string Liefernummer { get => liefernummer; set => liefernummer = value; }
        public DateTime Versanddatum { get => versanddatum; set => versanddatum = value; }
        public DateTime Lieferdatum { get => lieferdatum; set => lieferdatum = value; }
        public string NameVersandkontrolle { get => nameVersandkontrolle; set => nameVersandkontrolle = value; }
        public string NameSpedition { get => nameSpedition; set => nameSpedition = value; }
        //internal Bestellung Bestellung { get => bestellung; set => bestellung = value; }
    }
}
