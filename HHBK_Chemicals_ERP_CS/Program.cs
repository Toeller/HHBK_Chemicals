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
            

            controller.IView1 = view;
            controller.IModel1 = model;
            controllerBestellung.IModel1 = model;
            controllerKunde.IModel1 = model;
            controllerLagereingang.IModel1 = model;
            controllerLieferung.IModel1 = model;
            controllerProduktion.IModel1 = model;
            controllerProduktverwalten.IModel1 = model;
            controllerRechnungerstellen.IModel1 = model;
            controllerReklamation.IModel1 = model;
            controllerRezeptverwalten.IModel1 = model;
            controllerZahlungseingangpruefen.IModel1 = model;

            model.IView = view;
            model.createDB();
            model.createTestData();

            Application.Run((Form)view);
        }
    }
}
