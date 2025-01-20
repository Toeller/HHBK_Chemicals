﻿using System;
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

        private UserControlKunde ucKunde = new UserControlKunde();

        private IModel model;
        private IController controller;

        IModel IView.IModel { set => this.model = value; }
        IController IView.IController { set => this.controller = value; }

        private List<Kunde> kundenliste = new List<Kunde>();
        private List<Produkt> produktliste = new List<Produkt>();

        

        private UserControlProduktion ucProduktion = new UserControlProduktion();
        private UserControlProduktVerwalten ucProduktverwalten = new UserControlProduktVerwalten();
        private UserControlBestellung ucBestellung = new UserControlBestellung();
        private UserControlLagereingang ucLagereingang = new UserControlLagereingang();
        private UserControlLieferung ucLieferung = new UserControlLieferung();

        private co ucRechnungen = new co();
        private UserControlReklamation ucReklamation = new UserControlReklamation();
        private UserControlRezeptverwaltung ucRezeptverwaltung = new UserControlRezeptverwaltung();
        private UserControlZahlungseingangpruefen ucZahlungseingangpruefen = new UserControlZahlungseingangpruefen();

        public event EventHandler ViewProduktionFreigegeben;


        public View()
        {
            InitializeComponent();

            this.tabPage2.Text = "Kunde";
            this.tabPage2.Controls.Add(ucKunde);

            
           

            this.tabPage1.Text = "Bestellung";
            
            this.tabPage3.Text = "Lagereingang";
            this.tabPage4.Text = "Lieferung";
            this.tabPage5.Text = "Produktion";
            this.tabPage6.Text = "Produktverwalten";

            this.tabPage7.Text = "Rechnungen";
            this.tabPage8.Text = "Reklamation";
            this.tabPage9.Text = "Rezeptverwaltung";
            this.tabPage10.Text = "Zahlungseingänge";

            this.tabPage1.Controls.Add(ucBestellung);
            
            this.tabPage3.Controls.Add(ucLagereingang);
            this.tabPage4.Controls.Add(ucLieferung);
            this.tabPage5.Controls.Add(ucProduktion);
            this.tabPage6.Controls.Add(ucProduktverwalten);
            this.tabPage7.Controls.Add(ucRechnungen);
            this.tabPage8.Controls.Add(ucReklamation);
            this.tabPage9.Controls.Add(ucRezeptverwaltung);
            this.tabPage10.Controls.Add(ucZahlungseingangpruefen);


            ucProduktion.ProduktionFreigegeben += onProduktionFreigegeben;
            ucProduktverwalten.UCProduktVerwaltenAendern += onUCProduktverwaltenAendern;
            ucProduktverwalten.UCProduktVerwaltenLoeschen += onUCProduktverwaltenLoeschen;

            ucBestellung.VisibleChanged += onBestellungGotVisible;
            
            ucKunde.VisibleChanged += onKundeGotVisible;
            ucKunde.UCKundeAendern += onUCKundeAendern;
            ucKunde.UCKundeLoeschen += onUCKundeLoeschen;
            ucKunde.UCKundeSuchen += onUCKundeSuchen;

            ucLagereingang.VisibleChanged += onLagereingangGotVisible;
            ucLieferung.VisibleChanged += onLieferungGotVisible;
            ucProduktion.VisibleChanged += onProduktionGotVisible;
            ucProduktverwalten.VisibleChanged += onProduktverwaltenGotVisible;
            ucRechnungen.VisibleChanged += onRechnungenGotVisible;
            ucReklamation.VisibleChanged += onReklamationGotVisible;

            Model testmodel = new Model();
            testmodel.ModelProductsChanged += onModelProductsChanged;



        }

        private void onModelProductsChanged(object sender, EventArgs e)
        {
            model.getProdukte();
        }

        private void onReklamationGotVisible(object sender, EventArgs e)
        {
            try
            {
                ucReklamation.Reklamationen = model.getReklamationen();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void onRechnungenGotVisible(object sender, EventArgs e)
        {
            try
            {
                //ucRechnungen.Rechnungen = model.getRechnungen();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void onProduktionGotVisible(object sender, EventArgs e)
        {
            try
            {
                ucProduktion.Produktionslisten = model.getProduktionslisten();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void onLieferungGotVisible(object sender, EventArgs e)
        {
            try
            {
                ucLieferung.Bestellungen = model.getLieferungen();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void onProduktverwaltenGotVisible(object sender, EventArgs e)
        {

            try
            {
                ucProduktverwalten.Produktliste = model.getProdukte();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        

        private void onBestellungGotVisible(object sender, EventArgs e)
        {

            try
            {
                ucBestellung.Bestellungen = model.getBestellungen();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void onLagereingangGotVisible(object sender, EventArgs e)
        {
            try
            {
                ucLagereingang.Lagerpositionen = model.getLagerpositionen();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void onUCProduktverwaltenAendern(object sender, EventArgs e)
        {
            model.aendern(ucProduktverwalten.Produkt);
        }

        private void onUCProduktverwaltenLoeschen(object sender, EventArgs e)
        {
            model.loeschen(ucProduktverwalten.Produkt);
        }

        private void onKundeGotVisible(object sender, EventArgs e)
        {


            try
            {
                ucKunde.KundenListe = model.getKunden();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void onUCKundeAendern(object sender, EventArgs e)
        {
            if (ucKunde.Kunde.Kundennummer == -1)
                model.speichern(ucKunde.Kunde);
            else
                model.aendern(ucKunde.Kunde);
        }

        private void onUCKundeLoeschen(object sender, EventArgs e)
        {
            model.loeschen(ucKunde.Kunde);
        }

        private void onUCKundeSuchen(object sender, EventArgs e)
        {
            ucKunde.Kunde=model.sucheKunde(ucKunde.Kunde);
        }



        void onProduktionFreigegeben(object sender, EventArgs e)
        {
            MessageBox.Show("Produktion Freigegeben");
        }
        
        protected virtual void OnViewProduktionFreigegeben(EventArgs e)
        {
            EventHandler handler = ViewProduktionFreigegeben;
            handler?.Invoke(this, e);
        }

        

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start("C:/xampp/xampp_stop.exe");
        }

        void IView.Show(List<Produkt> produktliste)
        {
            ucProduktverwalten.Produktliste = produktliste;
        }

        void IView.Show(List<Kunde> kundenListe)
        {
            ucKunde.KundenListe = kundenListe;
        }
    }
}
