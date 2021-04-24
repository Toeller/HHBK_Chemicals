using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IModel
    {
        IViewProduktverwalten IViewProduktverwalten1 { set; }
        IViewRezeptverwalten IViewRezeptverwalten1 { set; }
        IViewLagereingang IViewLagereingang1 { set; }
        IViewBestellung IViewBestellung1 { set; }
        IViewRechnungerstellen IViewRechnungerstellen1 { set; }
        IViewZahlungseingangpruefen IViewZahlungseingangpruefen1 { set; }
        IViewProduktion IViewProduktion1 { set; }
        IViewLieferung IViewLieferung1 { set; }
        IViewReklamation IViewReklamation1 { set; }
        IViewKunde IViewKunde1 { set; }

        IControllerProduktverwalten IControllerProduktverwalten1 { set; }
        IControllerRezeptverwalten IControllerRezeptverwalten1 { set; }
        IControllerLagereingang IControllerLagereingang1 { set; }
        IControllerBestellung IControllerBestellung1 { set; }
        IControllerRechnungerstellen IControllerRechnungerstellen1 { set; }
        IControllerZahlungseingangpruefen IControllerZahlungseingangpruefen1 { set; }
        IControllerProduktion IControllerProduktion1 { set; }
        IControllerLieferung IControllerLieferung1 { set; }
        IControllerReklamation IControllerReklamation1 { set; }
        IControllerKunde IControllerKunde1 { set; }

        //Kunde
        Kunde GetKunde(int Kundennummer);

        Lieferposition GetLieferposition(int idLieferposition);


    }
}
