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


            model.IView = view;
            model.IController1 = controller;
            
            view.IController1 = controller;
            view.IModel1 = model;

            controller.IModel = model;
            controller.IForm1 = view;




            Application.Run((Form1)view);
        }
    }
}
