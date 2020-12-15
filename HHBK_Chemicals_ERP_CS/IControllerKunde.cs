using System.Collections.Generic;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControllerKunde
    {
        IModel Model { get; set; }
        void speichern(Kunde kunde);
        Kunde suchen(int kundennummer);
        List<Kunde> suchen(string name,
            string Vorname,
            string Strasse,
            string Hausnummer,
            string Postleitzahl,
            string Ort,
            string Emailadresse);
    }
}