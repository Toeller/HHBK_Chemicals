using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private List<Produkt> produkte=new List<Produkt>();
        private List<Kunde> kunden = new List<Kunde>();

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

        List<Kunde> IModel.getKunden()
        {
            Kunde kunde1 = new Kunde();
            List<Kunde> kundenliste = new List<Kunde>(); 

            mycommand.CommandText = "Select * from kunde";
            
            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader(); 
            
            while (reader.Read())
            {
                kunde1.Kundennummer    = Convert.ToInt32(reader["kundennummer"]);
                kunde1.Name         = reader["name"].ToString();
                kunde1.Vorname      = reader["vorname"].ToString();
                kunde1.Strasse = reader["strasse"].ToString();
                kunde1.Hausnummer = reader["hausnummer"].ToString();
                kunde1.Ort = reader["ort"].ToString();
                kunde1.Postleitzahl    = Convert.ToInt32(reader["postleitzahl"]);
                kunde1.Emailadresse = reader["emailadresse"].ToString();

                kundenliste.Add(kunde1);

            }
            reader.Close();
            conn.Close();
            //kunde1 = new Kunde(kundennummer, name, vorname, strasse, hausnummer, ort, postleitzahl, emailadresse);

            return kundenliste;
        }


        

        void IModel.aendern(Produkt produkt)
        {
            if (produkt.Artikelnummer != -1)
                mycommand.CommandText = Commands.change(produkt);
            else
                mycommand.CommandText = Commands.newEntity(produkt);

            MessageBox.Show(mycommand.CommandText);


            conn.Open();
            try
            {
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            //Über Event lösen!
            IModel a = this;
            view.Show(a.getProdukte());
        }

        void IModel.loeschen(Produkt produkt)
        {
           mycommand.CommandText = Commands.delete(produkt);
            //MessageBox.Show("Querry:" + mycommand.CommandText);

            conn.Open();
            try
            {
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        void IModel.bestellungSpeichern(List<Bestellposition> bestellung)
        {
            try
            {
                conn.Open();
                foreach (Bestellposition bestellposition in bestellung)
                {
                    mycommand.CommandText = Commands.newEntity(bestellposition);
                    mycommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);

                
            }
            finally
            {
                conn.Close();
            }

            
        }

        void IModel.createDB()
        {
            try
            {
                conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;";
                mycommand.CommandText = Commands.CreateDatabase;

                conn.Open();
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                //return false;
            }
            finally
            {
                conn.Close();
                conn.ConnectionString = myConnectionString;
            }

            //return true;

        }

       

        bool IModel.createTestData()
        {
            try
            {
                mycommand.CommandText = Commands.CreateTestdata;

                conn.Open();
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);

                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;

        }



        Lieferposition IModel.GetLieferposition(int idLieferposition)
        {
            throw new NotImplementedException();
        }

        void IModel.aendern(Kunde kunde)
        {
            if (kunde.Kundennummer != -1)
                mycommand.CommandText = Commands.change(kunde);
            else
                mycommand.CommandText = Commands.newEntity(kunde);

            MessageBox.Show(mycommand.CommandText);


            conn.Open();
            try
            {
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            //Über Event lösen!
            
            IModel a = this;
            view.Show(a.getKunden());
        }
        void IModel.loeschen(Kunde kunde)
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

        List<Produkt> IModel.getProdukte()
        {
           mycommand.CommandText = Commands.GetProduktIDandName;

           produkte.Clear();

            

            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader();
            
            while (reader.Read())
            {
                Produkt p = new Produkt();
                p.Artikelnummer = Convert.ToInt32(reader["Artikelnummer"]);
                p.Artikelname = reader["Artikelname"].ToString();
                p.Verkaufseinheit = Convert.ToInt32(reader["Verkaufseinheit"]);
                p.Einheit = reader["Einheit"].ToString();
                p.PreisVK = Convert.ToDouble(reader["PreisVK"]);
                p.ChemischeBezeichnung = reader["ChemischeBezeichnung"].ToString();
               
                produkte.Add(p);
            }



            conn.Close();
            return produkte;

        }

        List<Bestellung> IModel.getBestellungen()
        {
           
            List<Bestellung> bestellungen = new List<Bestellung>();

            mycommand.CommandText = "SELECT * FROM bestellposition";

            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader();

            while (reader.Read())
            {
                Bestellung bestellung1 = new Bestellung();
                bestellung1.Bestellpositionsnummer = Convert.ToInt32(reader["Bestellpositionsnummer"].ToString());
                bestellung1.Bestellungsnummer = Convert.ToInt32(reader["Bestellungsnummer"].ToString());
                bestellung1.Menge = Convert.ToInt32(reader["Menge"].ToString());
                //bestellung1.Bestelldatum =Convert.ToDateTime(reader["Bestelldatum"].ToString());
                bestellung1.Produkt.Artikelnummer = Convert.ToInt32(reader["Artikelnummer"].ToString());
                bestellung1.Kunde.Kundennummer = Convert.ToInt32(reader["Kundennummer"].ToString());
                if(int.TryParse(reader["Lieferpositionsnummer"].ToString(), out int result))
                  bestellung1.Lieferung.IdLieferposition = result;

                bestellungen.Add(bestellung1);

            }
            reader.Close();
            conn.Close();
            
            return bestellungen;
        }

        List<Lagerposition> IModel.getLagerpositionen()
        {
            throw new NotImplementedException();
        }

        List<Bestellung> IModel.getLieferungen()
        {
            throw new NotImplementedException();
        }
    }
}
