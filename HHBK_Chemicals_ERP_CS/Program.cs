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


            IModel model = new Model();
            IViewKunde viewKunde = new ViewKunde();
            IControllerKunde controllerKunde = new ControllerKunde();
            IController controller = new Controller();


            model.createDB();
            model.createTestData();
            

            viewKunde.controllerKunde = controllerKunde;
            controllerKunde.Model = model;
            
            Application.Run((ViewKunde)viewKunde);
        }
    }
}
