using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IViewZahlungseingangPruefen
    {
        void Anzeigen(int Zahlungseingangsnummer, string VerwendungszweckKdNr, string VerwendungszweckBestNr, string Datum, string NameKontoinhaber, string IBAN, int Kunde_Kundennummer);
        bool Aendern();
        bool Loeschen();

        int Zahlungseingansnummer 
        {
            get; set;
        }
    }


}
