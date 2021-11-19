﻿using System;
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

            model.IView1 = view;
            model.IController1 = controller;

            view.IController1 = controller;
            view.IModel1 = model;
            
            controller.IView1 = view;
            controller.IModel1 = model;
            

            
            model.createDB();
            model.createTestData();

            //model.createXML();

            Application.Run((Form)view);
        }
    }
}
