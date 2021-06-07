using System;
using System.Collections.Generic;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IForm1 view = new Form1();
            IController1 controller = new Controller1();
            IModel model = new Model();

            IControlerReklamation controlerReklamation = new ControlerReklamation();

            //Bestellung
            IController_Bestellung controller_Bestellung = new ControllerBestellung();
            controller_Bestellung.Model = model;
            //controller_Bestellung.View_Bestellung = view_Bestellung;


            model.IView = view;
            model.IController1 = controller;
            //model.IControllerBestellung = controller_Bestellung;

            view.IController1 = controller;
            view.IModel1 = model;
            //IView_Bestellung.IControllerBestellung = controller_Bestellung;

            controller.IModel = model;
            controller.IForm1 = view;

            controlerReklamation.IModel = model;
            //controlerReklamation.IView = viewReklamation;




            Application.Run((Form1)view);
        }
    }
}
