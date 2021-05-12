using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IModel
    {
        IView IView { set; }
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

        IController IController1 {set;}
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

        void createDB();
        bool createTestData();
        List<Kunde> getKunden();

        List<Produkt> getProdukte();
       

        Lieferposition GetLieferposition(int idLieferposition);


        void speichern(Kunde kunde);
        void speichern(Produkt produkt);
        void aendern(Kunde kunde);
        void aendern(Produkt produkt);
        void loeschen(Kunde kunde);
        void loeschen(Produkt produkt);
        Kunde sucheKunde(int kundennummer);
        List<Kunde> sucheKunde();
        Produkt suchenProdukt(int artikelnummer);
        List<Produkt> sucheProdukt();

        void bestellungSpeichern(List<Bestellposition> bestellung);



    }
}
