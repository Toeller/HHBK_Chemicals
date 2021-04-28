using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HHBK_Chemicals_ERP_CS
{
    class Model:IModel
    {
        private IView view;
        private IViewProduktverwalten viewProduktverwalten;
        private IViewRezeptverwalten viewRezeptverwalten;
        private IViewLagereingang viewLagereingang;
        private IViewBestellung viewBestellung;
        private IViewRechnungerstellen viewRechnungerstellen;
        private IViewZahlungseingangpruefen viewZahlungseingangpruefen;
        private IViewProduktion viewProduktion;
        private IViewLieferung viewLieferung;
        private IViewReklamation viewReklamation;
        private IViewKunde viewKunde;

        private IController controller;
        private IControllerProduktverwalten controllerProduktverwalten;
        private IControllerRezeptverwalten controllerRezeptverwalten;
        private IControllerLagereingang controllerLagereingang;
        private IControllerBestellung controllerBestellung;
        private IControllerRechnungerstellen controllerRechnungerstellen;
        private IControllerZahlungseingangpruefen controllerZahlungseingangpruefen;
        private IControllerProduktion controllerProduktion;
        private IControllerLieferung controllerLieferung;
        private IControllerReklamation controllerReklamation;
        private IControllerKunde controllerKunde;
       
        private string myConnectionString = "server=127.0.0.1;uid=erpModel;pwd=555HHBK;database=HHBK_Chemicals;";
        private MySqlConnection conn;
        private MySqlCommand mycommand;

        public Model()
        {
            conn = new MySqlConnection(myConnectionString);
            mycommand = conn.CreateCommand();
        }

        IViewProduktverwalten IModel.IViewProduktverwalten1 { set => this.viewProduktverwalten=value; }
        IViewRezeptverwalten IModel.IViewRezeptverwalten1 { set => this.viewRezeptverwalten=value; }
        IViewLagereingang IModel.IViewLagereingang1 { set => this.viewLagereingang=value; }
        IViewBestellung IModel.IViewBestellung1 { set => this.viewBestellung=value; }
        IViewRechnungerstellen IModel.IViewRechnungerstellen1 { set => this.viewRechnungerstellen=value; }
        IViewZahlungseingangpruefen IModel.IViewZahlungseingangpruefen1 { set => this.viewZahlungseingangpruefen=value; }
        IViewProduktion IModel.IViewProduktion1 { set => this.viewProduktion = value; }
        IViewLieferung IModel.IViewLieferung1 { set => this.viewLieferung=value; }
        IViewReklamation IModel.IViewReklamation1 { set => this.viewReklamation=value; }
        IViewKunde IModel.IViewKunde1 { set => this.viewKunde=value; }

        IControllerProduktverwalten IModel.IControllerProduktverwalten1 { set => this.controllerProduktverwalten = value; }
        IControllerRezeptverwalten IModel.IControllerRezeptverwalten1 { set => this.controllerRezeptverwalten=value; }
        IControllerLagereingang IModel.IControllerLagereingang1 { set => this.controllerLagereingang=value; }
        IControllerBestellung IModel.IControllerBestellung1 { set => this.controllerBestellung=value; }
        IControllerRechnungerstellen IModel.IControllerRechnungerstellen1 { set => this.controllerRechnungerstellen=value; }
        IControllerZahlungseingangpruefen IModel.IControllerZahlungseingangpruefen1 { set => this.controllerZahlungseingangpruefen=value; }
        IControllerProduktion IModel.IControllerProduktion1 { set => this.controllerProduktion=value; }
        IControllerLieferung IModel.IControllerLieferung1 { set => this.controllerLieferung=value; }
        IControllerReklamation IModel.IControllerReklamation1 { set => this.controllerReklamation=value; }
        IControllerKunde IModel.IControllerKunde1 { set => this.controllerKunde=value; }
        IView IModel.IView { set => this.view=value; }
        IController IModel.IController1 { set => this.controller=value; }

        public Kunde getKunde()
        {
            Kunde kunde1 = null;
            int kundennummer=0;
            string name="NN";
            string vorname="NN";
            string strasse="NN";
            string hausnummer="NN";
            string ort="NN";
            int postleitzahl=0;
            string emailadresse="NN";


           
           
            mycommand.CommandText = "Select * from kunde";
            
            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader(); 
            
            while (reader.Read())
            {
                kundennummer    = Convert.ToInt32(reader["kundennummer"]);
                name         = reader["name"].ToString();
                vorname      = reader["vorname"].ToString();
                strasse = reader["strasse"].ToString();
                hausnummer = reader["hausnummer"].ToString();
                ort = reader["ort"].ToString();
                postleitzahl    = Convert.ToInt32(reader["postleitzahl"]);
                emailadresse = reader["emailadresse"].ToString();
            }
            reader.Close();
            conn.Close();
            kunde1 = new Kunde(kundennummer, name, vorname, strasse, hausnummer, ort, postleitzahl, emailadresse);

            return kunde1;
        }


        void IModel.aendern(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        void IModel.aendern(Produkt produkt)
        {
            throw new NotImplementedException();
        }

        void IModel.bestellungSpeichern(List<Bestellposition> bestellung)
        {
            throw new NotImplementedException();
        }

        void IModel.createDB()
        {
            throw new NotImplementedException();
        }

        

        Lieferposition IModel.GetLieferposition(int idLieferposition)
        {
            throw new NotImplementedException();
        }

        void IModel.loeschen(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        void IModel.loeschen(Produkt produkt)
        {
            throw new NotImplementedException();
        }

        void IModel.speichern(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        void IModel.speichern(Produkt produkt)
        {
            throw new NotImplementedException();
        }

        Kunde IModel.sucheKunde(int kundennummer)
        {
            throw new NotImplementedException();
        }

        List<Kunde> IModel.sucheKunde()
        {
            throw new NotImplementedException();
        }

        Produkt IModel.suchenProdukt(int artikelnummer)
        {
            throw new NotImplementedException();
        }

        List<Produkt> IModel.sucheProdukt()
        {
            throw new NotImplementedException();
        }

        private void testen()
        {
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=test;";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand mycommand = conn.CreateCommand();
            mycommand.CommandText = "Select * from testtabelle"; conn.Open();

            //mycommand.CommandText = "Insert into testtabelle values(NULL,'" + textBoxName.Text.ToString() + "','" + textBoxVorname.Text.ToString() + "')";

            MySqlDataReader reader = mycommand.ExecuteReader(); while (reader.Read())
            {
            //label1.Text = reader["testTabelleID"].ToString();
            }
            //Datenbank -> Kunde holen
            Kunde kunde1 = null;
            //return kunde1;
        }
    }
}
