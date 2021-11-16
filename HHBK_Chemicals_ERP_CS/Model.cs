using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.model;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HHBK_Chemicals_ERP_CS
{
    public class Model:IModel
    {
        private IView view;
        private IController controller;
        IView IModel.IView1 { set => this.view = value; }
        IController IModel.IController1 { set => this.controller = value; }

        //private IKundenliste kunden=new Kundenliste();

        private IKundenliste kunden = new KundenlisteXML();


        #region DB Attribute ändern!
        private string myConnectionString = "server=127.0.0.1;uid=erpModel;pwd=555HHBK;database=HHBK_Chemicals;";
        private MySqlConnection conn;
        private MySqlCommand mycommand;
        #endregion

        private List<Produkt> produkte=new List<Produkt>();
        

        public Model()
        {
            conn = new MySqlConnection(myConnectionString);
            mycommand = conn.CreateCommand();
        }
        
        

        #region Kunde
        
        List<Kunde> IModel.getKunden()
        {
            return kunden.Kunden;
        }

        void IModel.aendern(Kunde kunde)
        {
            kunden.alter(kunde);
        }
        void IModel.loeschen(Kunde kunde)
        {
            kunden.delete(kunde);
        }
        void IModel.speichern(Kunde kunde)
        {
            kunden.save(kunde);
        }

        Kunde IModel.sucheKunde(int kundennummer)
        {
            return kunden.getKunde(kundennummer);
        }

        List<Kunde> IModel.sucheKunde()
        {
            return kunden.Kunden;
        }

        #endregion


        #region Produkt
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

        void IModel.speichern(Produkt produkt)
        {
            throw new NotImplementedException();
        }

        List<Produktionsliste> IModel.getProduktionslisten()
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

        #endregion


        #region Bestellung
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

        List<Bestellung> IModel.getBestellungen()
        {

            List<Bestellung> bestellungen = new List<Bestellung>();

            mycommand.CommandText = Commands.getBestellungen;

            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader();

            while (reader.Read())
            {
                Bestellung bestellung1 = new Bestellung();
                bestellung1.Bestellpositionsnummer = Convert.ToInt32(reader["Bestellpositionsnummer"].ToString());
                bestellung1.Bestellungsnummer = Convert.ToInt32(reader["Bestellungsnummer"].ToString());
                bestellung1.Menge = Convert.ToInt32(reader["Menge"].ToString());
                bestellung1.Bestelldatum = Convert.ToDateTime(reader["Bestelldatum"].ToString());
                bestellung1.Produkt.Artikelnummer = Convert.ToInt32(reader["Artikelnummer"].ToString());
                bestellung1.Kunde.Kundennummer = Convert.ToInt32(reader["Kundennummer"].ToString());
                bestellung1.Produkt.Artikelname = reader["Artikelname"].ToString();
                bestellung1.Produkt.Verkaufseinheit = Convert.ToInt32(reader["Verkaufseinheit"].ToString());
                bestellung1.Produkt.PreisVK = Convert.ToDouble(reader["PreisVK"].ToString());
                if (int.TryParse(reader["Lieferpositionsnummer"].ToString(), out int result))
                    bestellung1.Lieferung.IdLieferposition = result;

                bestellungen.Add(bestellung1);

            }
            reader.Close();
            conn.Close();

            return bestellungen;
        }
        #endregion


        #region DB
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

        #endregion

        #region Lieferposition

        Lieferposition IModel.GetLieferposition(int idLieferposition)
        {
            throw new NotImplementedException();
        }
        List<Bestellung> IModel.getLieferungen()
        {
            throw new NotImplementedException();
        }

        #endregion

        List<Lagerposition> IModel.getLagerpositionen()
        {
            throw new NotImplementedException();
        }

        List<Reklamation> IModel.getReklamationen()
        {
            throw new NotImplementedException();
        }

       
    }
}
