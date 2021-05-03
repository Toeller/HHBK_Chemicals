using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IController_Bestellung
    {
        IModel Model { set; }
        IView_Bestellung View_Bestellung { set; }
        int Anlegen(Bestellung bestellung, Kunde kunde);
        int Andern(Bestellung bestellung, Bestellung newBestellung);
        int Loeschen(List<Bestellposition> bestellpositionen);

        int bestellungSpeichern(List<Bestellposition> bestellposition);

        string SpeicherAktuellesStatus<T>(T obj,string fileName);

        T Ladenaktuellestatus<T>(string fileName);
    }
}
