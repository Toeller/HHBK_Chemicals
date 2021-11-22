using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    public interface IModel
    {
        IView IView1 { set; }
        

        IController IController1 {set;}


        void createXML();
        void createDB();
        bool createTestData();
        List<Kunde> getKunden();

        List<Produkt> getProdukte();

        List<Bestellung> getBestellungen();

        List<Lagerposition> getLagerpositionen();
        Lieferposition GetLieferposition(int idLieferposition);

        List<Bestellung> getLieferungen();

        void speichern(Kunde kunde);
        void speichern(Produkt produkt);
        void aendern(Kunde kunde);
        void aendern(Produkt produkt);
        void loeschen(Kunde kunde);
        void loeschen(Produkt produkt);
        Kunde sucheKunde(int kundennummer);

        Kunde sucheKunde(Kunde kunde);

        List<Kunde> sucheKunde();
        Produkt suchenProdukt(int artikelnummer);
        List<Produkt> sucheProdukt();

        void bestellungSpeichern(List<Bestellposition> bestellung);

        List<Reklamation> getReklamationen();

        List<Produktionsliste> getProduktionslisten();

    }
}
