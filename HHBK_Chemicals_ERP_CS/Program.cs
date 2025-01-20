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

            model.IView = view;
            model.IController = controller;

            view.IController = controller;
            view.IModel = model;
            
            controller.IView = view;
            controller.IModel = model;
            

            
            Application.Run((Form)view);
        }
    }
}
