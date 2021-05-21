using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HHBK_Chemicals_ERP_CS
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process.Start("C:/xampp/xampp_start.exe");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();

            IView view = new View();
            IViewBestellung viewBestellung = new ViewBestellung();
            IViewKunde viewKunde = new ViewKunde();
            IViewLagereingang viewLagereingang = new ViewLagereingang();
            IViewLieferung viewLieferung = new ViewLieferung();
            IViewProduktion viewProduktion = new ViewProduktion();
            IViewProduktverwalten viewProduktverwalten = new ViewProduktverwalten();
            IViewRechnungerstellen viewRechnungerstellen = new ViewRechnungerstellen();
            IViewReklamation viewReklamation = new ViewReklamation();
            IViewRezeptverwalten viewRezeptverwalten = new ViewRezeptverwalten();
            IViewZahlungseingangpruefen viewZahlungseingangpruefen = new ViewZahlungseingangpruefen();

            IController controller = new Controller();
            IControllerBestellung controllerBestellung = new ControllerBestellung();
            IControllerKunde controllerKunde = new ControllerKunde();
            IControllerLagereingang controllerLagereingang = new ControllerLagereingang();
            IControllerLieferung controllerLieferung = new ControllerLieferung();
            IControllerProduktion controllerProduktion = new ControllerProduktion();
            IControllerProduktverwalten controllerProduktverwalten = new ControllerProduktverwalten();
            IControllerRechnungerstellen controllerRechnungerstellen = new ControllerRechnungerstellen();
            IControllerReklamation controllerReklamation = new ControllerReklamation();
            IControllerRezeptverwalten controllerRezeptverwalten = new ControllerRezeptverwalten();
            IControllerZahlungseingangpruefen controllerZahlungseingangpruefen = new ControllerZahlungseingangpruefen();

            view.IController1 = controller;
            view.IModel1 = model;
            viewBestellung.IControllerBestellung1 = controllerBestellung;
            viewBestellung.IModel1 = model;
            viewKunde.IControllerKunde1 = controllerKunde;
            viewKunde.IModel1 = model;
            viewLagereingang.IControllerLagereingang1 = controllerLagereingang;
            viewLagereingang.IModel1 = model;
            viewLieferung.IControllerlieferung1 = controllerLieferung;
            viewLieferung.IModel1 = model;
            viewProduktion.IControllerProduktion1 = controllerProduktion;
            viewProduktion.IModel1 = model;
            viewProduktverwalten.IControllerProduktverwalten1 = controllerProduktverwalten;
            viewProduktverwalten.IModel1 = model;
            viewRechnungerstellen.IControllerRechnungerstellen1 = controllerRechnungerstellen;
            viewRechnungerstellen.IModel1 = model;
            viewReklamation.IControllerReklamation1 = controllerReklamation;
            viewReklamation.IModel1 = model;
            viewRezeptverwalten.IControllerRezeptverwalten1 = controllerRezeptverwalten;
            viewRezeptverwalten.IModel1 = model;
            viewZahlungseingangpruefen.IControllerZahlungseingangpruefen1 = controllerZahlungseingangpruefen;
            viewZahlungseingangpruefen.IModel1 = model;

            controller.IView1 = view;
            controller.IModel1 = model;
            controllerBestellung.IViewBestellung1 = viewBestellung;
            controllerBestellung.IModel1 = model;
            controllerKunde.IViewKunde1 = viewKunde;
            controllerKunde.IModel1 = model;
            controllerLagereingang.IViewLagereingang1 = viewLagereingang;
            controllerLagereingang.IModel1 = model;
            controllerLieferung.IViewLieferung1 = viewLieferung;
            controllerLieferung.IModel1 = model;
            controllerProduktion.IViewProduktion1 = viewProduktion;
            controllerProduktion.IModel1 = model;
            controllerProduktverwalten.IViewProduktverwalten1 = viewProduktverwalten;
            controllerProduktverwalten.IModel1 = model;
            controllerRechnungerstellen.IViewRechnungerstellen1 = viewRechnungerstellen;
            controllerRechnungerstellen.IModel1 = model;
            controllerReklamation.IViewReklamation1 = viewReklamation;
            controllerReklamation.IModel1 = model;
            controllerRezeptverwalten.IViewRezeptverwalten1 = viewRezeptverwalten;
            controllerRezeptverwalten.IModel1 = model;
            controllerZahlungseingangpruefen.IViewZahlungseingangpruefen1 = viewZahlungseingangpruefen;
            controllerZahlungseingangpruefen.IModel1 = model;

            model.createDB();
            model.createTestData();

            Application.Run((Form)view);
        }
    }
}
