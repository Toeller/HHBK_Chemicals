using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS
{
    public partial class View : Form, IView
    {
        private IModel model;
        private IController controller;
        public View()
        {
            InitializeComponent();
            this.tabPage1.Text = "Bestellung";
            this.tabPage2.Text = "Kunde";
            this.tabPage3.Text = "Lagereingang";
            this.tabPage4.Text = "Lieferung";
            this.tabPage5.Text = "Produktion";
            this.tabPage6.Text = "Produktverwalten";
            this.tabPage7.Text = "Rechnungstellen";
            this.tabPage8.Text = "Reklamation";
            this.tabPage9.Text = "Rezeptverwaltung";
            this.tabPage10.Text = "Zahlungseingangprüfen";

            this.tabPage2.Controls.Add(new UserControlKunde());
            

        }

        IModel IView.IModel1 { set => this.model=value; }
        IController IView.IController1 { set => this.controller=value; }
    }
}
