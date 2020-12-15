using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HHBK_Chemicals_ERP_CS
{
    class Lieferposition
    {
        private int idLieferposition;
        private string liefernummer;
        private DateTime versanddatum;
        private DateTime lieferdatum;
        private string nameVersandKontrolle;
        private string nameSpedition;

        public int IdLieferposition { get => idLieferposition; set => idLieferposition = value; }
        public string Liefernummer { get => liefernummer; set => liefernummer = value; }
        public DateTime Versanddatum { get => versanddatum; set => versanddatum = value; }
        public DateTime Lieferdatum { get => lieferdatum; set => lieferdatum = value; }
        public string NameVersandKontrolle { get => nameVersandKontrolle; set => nameVersandKontrolle = value; }
        public string NameSpedition { get => nameSpedition; set => nameSpedition = value; }
    }
}
