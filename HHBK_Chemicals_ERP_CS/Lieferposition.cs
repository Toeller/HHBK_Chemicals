using System;

namespace HHBK_Chemicals_ERP_CS
{
    public class Lieferposition
    {
        private int idLieferposition;
        private String Liefernummer;
        private DateTime Versanddatum;
        private DateTime Lieferdatum;
        private String NameVersandkontrolle;
        private String NameSpedition;

        public Lieferposition(int idLieferposition, String Liefernummer, DateTime Versanddatum,
            DateTime Lieferdatum, String NameVersandkontrolle, String NameSpedition)
        {
            this.idLieferposition = idLieferposition;
            this.Liefernummer = Liefernummer;
            this.Versanddatum = Versanddatum;
            this.Lieferdatum = Lieferdatum;
            this.NameVersandkontrolle = NameVersandkontrolle;
            this.NameSpedition = NameSpedition;
        }
    }
}