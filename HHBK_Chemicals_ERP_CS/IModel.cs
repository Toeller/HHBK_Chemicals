using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IModel
    {
        /*Zahlungseingang braucht in der Zukunft
         *  den Zugang  auf die Daten der Datenbank Zahlungseingang*/

        int Zahlungseingangsnummer { get; set; }                            // methode mit dem namen Zahlungseingangsnummer
        string VerwendungszweckKdNr { get; set; }                           //methode mit dem namen VerwendungszweckKdNr
        string VerwendungszweckBestNr { get; set; }                         //methode mit dem namen VerwendungszweckBestNr
        string Datum { get; set; }                                          //methode mit dem namen Datum
        string NameKontoinhaber { get; set; }                               //methode mit dem namen NameKontoinhaber
        string IBAN { get; set; }                                           //methode mit dem namen IBAN 

        void Ausgabe();                                                     // methode mit dem namen Ausgabe
    }
}
