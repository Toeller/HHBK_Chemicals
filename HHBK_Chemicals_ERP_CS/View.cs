using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Kunde> kundenliste = new List<Kunde>();
        private List<Produkt> produktliste = new List<Produkt>();
        private UserControlKunde ucKunde = new UserControlKunde();
        private UserControlProduktion ucProduktion = new UserControlProduktion();
        private UserControlProduktVerwalten ucProduktverwalten = new UserControlProduktVerwalten();
        private UserControlBestellung ucBestellung = new UserControlBestellung();
        private UserControlLagereingang ucLagereingang = new UserControlLagereingang();
        private UserControlLieferung ucLieferung = new UserControlLieferung();

        public event EventHandler ViewProduktionFreigegeben;
        

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
            
            this.tabPage2.Controls.Add(ucKunde);
            this.tabPage6.Controls.Add(ucProduktverwalten);
            this.tabPage1.Controls.Add(ucBestellung);
            this.tabPage3.Controls.Add(ucLagereingang);
            this.tabPage4.Controls.Add(ucLieferung);
            this.tabPage5.Controls.Add(ucProduktion);
            ucProduktion.ProduktionFreigegeben += onProduktionFreigegeben;
            ucProduktverwalten.VisibleChanged += onProduktverwaltenGotVisible;
            ucProduktverwalten.UCProduktVerwaltenAendern += onUCProduktverwaltenAendern;
            ucProduktverwalten.UCProduktVerwaltenLoeschen += onUCProduktverwaltenLoeschen;
        }

        private void onUCProduktverwaltenAendern(object sender, EventArgs e)
        {
            model.aendern(ucProduktverwalten.Produkt);
        }

        private void onUCProduktverwaltenLoeschen(object sender, EventArgs e)
        {
            model.loeschen(ucProduktverwalten.Produkt);
        }

        private void onProduktverwaltenGotVisible(object sender, EventArgs e)
        {
            ucProduktverwalten.Produktliste = model.getProdukte();
            
        }

        IModel IView.IModel1 { set => this.model=value; }
        IController IView.IController1 { set => this.controller=value; }

        void onProduktionFreigegeben(object sender, EventArgs e)
        {
            MessageBox.Show("Produktion Freigegeben");
        }

        

        protected virtual void OnViewProduktionFreigegeben(EventArgs e)
        {
            EventHandler handler = ViewProduktionFreigegeben;
            handler?.Invoke(this, e);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {



            switch(this.tabControl1.SelectedIndex.ToString())
            {
                case "0":
                    break;
                case "1":

                    this.kundenliste=model.getKunden();
                    //uck.
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
            }
            
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start("C:/xampp/xampp_stop.exe");
        }
    }
}
